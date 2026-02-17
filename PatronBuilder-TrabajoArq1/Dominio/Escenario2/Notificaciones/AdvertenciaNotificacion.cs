using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario2
{
    public sealed class AdvertenciaNotificacion(INotificacionPlataforma plataforma, string Titulo, string details) : Notificacion(plataforma)
    {
        private readonly string _Titulo = Titulo;
        private readonly string _details = details;

        protected override NotificacionCargarRegistro  ConstruirRegistroMostrar() =>
            new(
                Titulo: _Titulo,
                Cabecera: _details,
                Category: "Advertencia",
                Severidad: Severidad.Prevencion,
                Tiempo: DateTimeOffset.UtcNow
            );
    }
}