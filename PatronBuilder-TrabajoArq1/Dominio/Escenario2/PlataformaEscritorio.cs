using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario2
{
    // Implementaciones concretas
    public sealed class PlataformaEscritorio : INotificacionPlataforma
    {
        public void Pantalla(NotificacionCargarRegistro  p)
        {
            Console.WriteLine("=== [escritorio] ===");
            Console.WriteLine($"{p.Tiempo:u} | {p.Category} | {p.Severidad}");
            Console.WriteLine($"Titulo: {p.Titulo}");
            Console.WriteLine($"CABECERA : {p.Cabecera}");
            Console.WriteLine();
        }
    }
}