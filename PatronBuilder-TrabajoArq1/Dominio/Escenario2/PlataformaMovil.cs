using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario2
{
    public sealed class PlataformaMovil : INotificacionPlataforma
    {
        public void Pantalla(NotificacionCargarRegistro  p)
        {
            Console.WriteLine("=== [movil] ===");
            Console.WriteLine($"[{p.Severidad}] {p.Titulo} - {Truncate(p.Cabecera, 40)}");
            Console.WriteLine($"{p.Titulo} ");
             Console.WriteLine();
        }

        private static string Truncate(string s, int max)
            => s.Length <= max ? s : s.Substring(0, max - 3) + "...";
    }
}