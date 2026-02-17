using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario2
{
    public sealed class MensajeNotificacion(INotificacionPlataforma plataforma, string from, string message) : Notificacion(plataforma)
    {
        private readonly string _from = from;
        private readonly string _message = message;

        protected override NotificacionCargarRegistro  ConstruirRegistroMostrar() =>
            new(
                Titulo: $"Nuevo mensaje de {_from}",
                Cabecera: _message,
                Category: "Mensaje",
                Severidad: Severidad.Informacion,
                Tiempo: DateTimeOffset.UtcNow
            );
    }
}