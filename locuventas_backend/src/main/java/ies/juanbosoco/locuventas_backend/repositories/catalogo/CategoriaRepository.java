package ies.juanbosoco.locuventas_backend.repositories.catalogo;

import ies.juanbosoco.locuventas_backend.entities.catalogo.Categoria;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

@Repository
public interface CategoriaRepository extends JpaRepository<Categoria, Long> {
    boolean existsByNombreAndIdNot(String nombre, Long id);
    boolean existsByNombre(String nombre);

    @Query("SELECT c FROM Categoria c WHERE (:search IS NULL OR :search = '' OR LOWER(c.nombre) LIKE LOWER(CONCAT('%', :search, '%')))")
    Page<Categoria> findAllWithSearch(@Param("search") String search, Pageable pageable);
}
