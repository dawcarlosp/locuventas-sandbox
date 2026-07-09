Imports System.Text.Json

Imports System.Net.Http

Public Class ProductoEditForm
    Private editId As Long?
    Private selectedFotoBytes As Byte()
    Private selectedFotoName As String
    Private paisesList As List(Of PaisResponse)
    Private categoriasList As List(Of CategoriaResponse)

    Public Sub New()
        InitializeComponent()
        Me.editId = Nothing
        Me.lblTitle.Text = "Nuevo Producto"
        Me.Text = "Nuevo Producto"
    End Sub

    Public Sub New(productoId As Long)
        InitializeComponent()
        Me.editId = productoId
        Me.lblTitle.Text = "Editar Producto"
        Me.Text = "Editar Producto"
    End Sub

    Private Async Sub ProductoEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadPaises()
        Await LoadCategorias()

        If editId.HasValue Then
            Await LoadProducto(editId.Value)
        End If
    End Sub

    Private Async Function LoadPaises() As Task
        Try
            Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of List(Of PaisResponse)))("/paises")
            paisesList = response.Data

            cmbPais.Items.Clear()
            For Each p In paisesList
                cmbPais.Items.Add(p.Nombre)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al cargar países: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function LoadCategorias() As Task
        Try
            Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of List(Of CategoriaResponse)))("/categorias")
            categoriasList = response.Data

            clbCategorias.Items.Clear()
            For Each c In categoriasList
                clbCategorias.Items.Add(c.Nombre, False)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function LoadProducto(id As Long) As Task
        Try
            Cursor = Cursors.WaitCursor

            Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of PageDTO(Of ProductoResponse)))(
                $"/productos?page=0&size=100&search=")

            Dim producto As ProductoResponse = Nothing
            If response.Data IsNot Nothing AndAlso response.Data.Content IsNot Nothing Then
                producto = response.Data.Content.FirstOrDefault(Function(p) p.Id = id)
            End If

            If producto Is Nothing Then
                MessageBox.Show("Producto no encontrado.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
                Return
            End If

            txtNombre.Text = producto.Nombre
            txtPrecio.Text = producto.Precio.ToString()
            txtIva.Text = producto.Iva.ToString()

            For i = 0 To paisesList.Count - 1
                If paisesList(i).Nombre = producto.PaisNombre Then
                    cmbPais.SelectedIndex = i
                    Exit For
                End If
            Next

            For i = 0 To clbCategorias.Items.Count - 1
                Dim catName = clbCategorias.Items(i).ToString()
                clbCategorias.SetItemChecked(i, producto.Categorias IsNot Nothing AndAlso
                    producto.Categorias.Contains(catName))
            Next

            If Not String.IsNullOrEmpty(producto.Foto) Then
                Try
                    Dim fotoUrl = $"http://localhost:8080/imagenes/{producto.Foto}"
                    Using httpClient = New HttpClient()
                        Dim imageBytes = Await httpClient.GetByteArrayAsync(fotoUrl)
                        Dim ms = New IO.MemoryStream(imageBytes)
                        picFoto.Image = Image.FromStream(ms)
                    End Using
                Catch
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al cargar producto: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub btnSubirFoto_Click(sender As Object, e As EventArgs) Handles btnSubirFoto.Click
        Using ofd = New OpenFileDialog()
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.webp;*.jfif|Todos|*.*"
            ofd.Title = "Seleccionar imagen del producto"

            If ofd.ShowDialog() = DialogResult.OK Then
                selectedFotoBytes = IO.File.ReadAllBytes(ofd.FileName)
                selectedFotoName = IO.Path.GetFileName(ofd.FileName)

                Using ms = New IO.MemoryStream(selectedFotoBytes)
                    picFoto.Image = Image.FromStream(ms)
                End Using
            End If
        End Using
    End Sub

    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidateFields() Then Return

        btnGuardar.Enabled = False
        btnGuardar.Text = "Guardando..."

        Try
            If cmbPais.SelectedIndex < 0 Then
                MessageBox.Show("Selecciona un país.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedCategoriaIds = New List(Of Long)()
            For i = 0 To clbCategorias.CheckedItems.Count - 1
                Dim catName = clbCategorias.CheckedItems(i).ToString()
                Dim cat = categoriasList.FirstOrDefault(Function(c) c.Nombre = catName)
                If cat IsNot Nothing Then
                    selectedCategoriaIds.Add(cat.Id)
                End If
            Next

            If selectedCategoriaIds.Count = 0 Then
                MessageBox.Show("Selecciona al menos una categoría.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim paisId = paisesList(cmbPais.SelectedIndex).Id

            Cursor = Cursors.WaitCursor

            If editId.HasValue Then
                Dim request = New ProductoUpdateRequest With {
                    .Nombre = txtNombre.Text.Trim(),
                    .Precio = Decimal.Parse(txtPrecio.Text.Trim()),
                    .Iva = Double.Parse(txtIva.Text.Trim()),
                    .PaisId = paisId,
                    .CategoriaIds = selectedCategoriaIds
                }

                Await ProductoService.Update(editId.Value, request,
                    selectedFotoBytes, selectedFotoName)
                MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If selectedFotoBytes Is Nothing Then
                    MessageBox.Show("Debes seleccionar una imagen para el producto.", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim request = New ProductoCreateRequest With {
                    .Nombre = txtNombre.Text.Trim(),
                    .Precio = Decimal.Parse(txtPrecio.Text.Trim()),
                    .Iva = Double.Parse(txtIva.Text.Trim()),
                    .PaisId = paisId,
                    .CategoriaIds = selectedCategoriaIds
                }

                Await ProductoService.Create(request, selectedFotoBytes, selectedFotoName)
                MessageBox.Show("Producto creado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As ApiException
            Try
                Dim errorObj = JsonSerializer.Deserialize(Of ApiResponse(Of Object))(ex.ResponseContent)
                MessageBox.Show($"Error: {errorObj?.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch
                MessageBox.Show($"Error del servidor: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
            btnGuardar.Enabled = True
            btnGuardar.Text = "Guardar"
        End Try
    End Sub

    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre es obligatorio.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecio.Text.Trim(), Nothing) OrElse
           Not Decimal.TryParse(txtPrecio.Text.Trim(), precio) OrElse precio <= 0 Then
            MessageBox.Show("El precio debe ser un número mayor que 0.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False
        End If

        Dim iva As Double
        If Not Double.TryParse(txtIva.Text.Trim(), iva) OrElse iva < 0 OrElse iva > 100 Then
            MessageBox.Show("El IVA debe ser un número entre 0 y 100.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIva.Focus()
            Return False
        End If

        If cmbPais.SelectedIndex < 0 Then
            MessageBox.Show("Selecciona un país.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub ProductoEditForm_LoadStyle() Handles MyBase.Load
        StyleBtnPrimary(btnGuardar)
        StyleBtnSecondary(btnCancelar)
        StyleBtnSecondary(btnSubirFoto)
        StyleInput(txtNombre)
        StyleInput(txtPrecio)
        StyleInput(txtIva)
        StyleCombo(cmbPais)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
