using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario2
{
    public sealed class PlataformaWeb : INotificacionPlataforma
    {
        public void Pantalla(NotificacionCargarRegistro  p)
        {
            Console.WriteLine("=== [WEB] ===");
            Console.WriteLine($"<div class='Grave {p.Severidad.ToString().ToLower()}'>");
            Console.WriteLine($"  <b>{Escape(p.Titulo)}</b>");
            Console.WriteLine($"  <span>{Escape(p.Category)}</span>");
            Console.WriteLine($"  <i>{p.Tiempo:u}</i>");
            Console.WriteLine("</div>");
            Console.WriteLine();
        }

        private static string Escape(string s)
            => s.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
    }
}