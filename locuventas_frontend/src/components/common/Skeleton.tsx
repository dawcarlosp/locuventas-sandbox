type SkeletonVariant = "producto-card" | "tarjeta-vendedor" | "venta-card" | "producto-gestion-card" | "categoria-card";

interface SkeletonProps {
  variant: SkeletonVariant;
}

export default function Skeleton({ variant }: SkeletonProps) {
  switch (variant) {
    case "producto-card":
      return (
        <div className="relative rounded-2xl bg-zinc-900 border border-zinc-800 flex flex-col p-4 gap-3 w-full max-w-[260px] h-[280px] animate-pulse">
          <div className="flex flex-col gap-2 min-h-[44px]">
            <div className="h-2 w-8 rounded bg-zinc-700" />
            <div className="h-4 w-40 rounded bg-zinc-700" />
            <div className="h-4 w-24 rounded bg-zinc-700/60" />
          </div>
          <div className="h-28 rounded-xl bg-zinc-800 border border-zinc-700/30" />
          <div className="flex flex-col gap-2 mt-auto pt-2 border-t border-zinc-800/50">
            <div className="h-2 w-20 rounded bg-zinc-700/50" />
            <div className="flex justify-between items-end">
              <div className="h-5 w-16 rounded bg-zinc-700" />
              <div className="h-6 w-14 rounded bg-zinc-800 border border-zinc-700" />
            </div>
          </div>
        </div>
      );

    case "tarjeta-vendedor":
      return (
        <li className="flex items-center gap-3 p-3 rounded-xl bg-zinc-800/50 animate-pulse">
          <div className="w-10 h-10 rounded-full bg-zinc-700 flex-shrink-0" />
          <div className="flex-1 flex flex-col gap-2">
            <div className="h-3 w-32 rounded-md bg-zinc-700" />
            <div className="h-2 w-48 rounded-md bg-zinc-700/70" />
            <div className="h-2 w-20 rounded-md bg-zinc-700/50" />
          </div>
          <div className="flex flex-col gap-2 flex-shrink-0">
            <div className="h-7 w-20 rounded-xl bg-zinc-700" />
            <div className="h-7 w-20 rounded-xl bg-zinc-700/70" />
          </div>
        </li>
      );

    case "venta-card":
      return (
        <div className="rounded-2xl bg-zinc-900 border border-zinc-700 flex flex-col gap-3 p-4 w-full animate-pulse">
          <div className="flex justify-between items-center">
            <div className="h-4 w-12 bg-zinc-700 rounded" />
            <div className="h-5 w-16 bg-zinc-700 rounded-full" />
          </div>
          <div className="flex flex-col gap-2">
            {Array.from({ length: 3 }).map((_, i) => (
              <div key={i} className="flex justify-between">
                <div className="h-3 w-16 bg-zinc-700/50 rounded" />
                <div className="h-3 w-24 bg-zinc-700/50 rounded" />
              </div>
            ))}
          </div>
          <div className="flex flex-col gap-2 pt-2 border-t border-zinc-800">
            <div className="h-8 bg-zinc-700/50 rounded-xl" />
          </div>
        </div>
      );

    case "producto-gestion-card":
      return (
        <div className="rounded-2xl bg-zinc-900 border border-zinc-700 flex flex-col gap-3 p-4 animate-pulse">
          <div className="flex justify-between items-center">
            <div className="h-3 w-8 bg-zinc-700 rounded" />
            <div className="flex gap-2">
              <div className="h-8 w-14 bg-zinc-700 rounded-xl" />
              <div className="h-8 w-16 bg-zinc-700 rounded-xl" />
            </div>
          </div>
          <div className="h-28 bg-zinc-800 rounded-xl border border-zinc-700/30" />
          <div className="flex flex-col gap-2">
            {Array.from({ length: 4 }).map((_, i) => (
              <div key={i} className="flex justify-between">
                <div className="h-3 w-16 bg-zinc-700/50 rounded" />
                <div className="h-3 w-24 bg-zinc-700/50 rounded" />
              </div>
            ))}
          </div>
        </div>
      );

    case "categoria-card":
      return (
        <div className="rounded-2xl bg-zinc-900 border border-zinc-700 flex flex-col gap-3 p-4 animate-pulse">
          <div className="flex justify-between items-center">
            <div className="h-3 w-8 bg-zinc-700 rounded" />
            <div className="flex gap-2">
              <div className="h-8 w-14 bg-zinc-700 rounded-xl" />
              <div className="h-8 w-16 bg-zinc-700 rounded-xl" />
            </div>
          </div>
          <div className="flex justify-between items-start gap-2">
            <div className="h-3 w-12 bg-zinc-700/50 rounded" />
            <div className="h-3 w-32 bg-zinc-700 rounded" />
          </div>
        </div>
      );

    default:
      return null;
  }
}
