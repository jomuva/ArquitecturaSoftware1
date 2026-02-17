using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario2
{
    // =========================
    // Implementar (Plataforma)
    // =========================
    public interface INotificacionPlataforma
    {
         void Pantalla(NotificacionCargarRegistro cargarregistro);
    }

    // Si  agrego un nuevo tipo de notificación,
    // solamente se crea una nueva Abstraction (subclase) que produzca un cargarregistro.
    public sealed record NotificacionCargarRegistro (
        string Titulo,
        string Cabecera,
        string Category,    // "Mensaje", "Alerta", "Advertencia", "Confirmación", etc.
        Severidad Severidad,
        DateTimeOffset Tiempo
    );

    public enum Severidad
    {
        Informacion,
        Suceso,
        Prevencion,
        Error
    }
}