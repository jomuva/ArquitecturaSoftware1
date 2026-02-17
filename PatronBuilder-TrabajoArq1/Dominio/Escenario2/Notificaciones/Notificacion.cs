using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario2
{
     // =========================
    // Abstraccion (Notificación)
    // =========================
    public abstract class Notificacion(INotificacionPlataforma plataforma)
    {

        // Permite cambiar la plataforma en tiempo de ejecución (beneficio esperado).
        public INotificacionPlataforma Plataforma { get; set; } = plataforma ??
            throw new ArgumentNullException(nameof(plataforma));

        public void Mostrar()
        {
            var cargarregistro = ConstruirRegistroMostrar();
            Plataforma.Pantalla(cargarregistro);
        }

        // Cada tipo de notificación define su "abstracción" (qué es y qué datos produce).
        protected abstract NotificacionCargarRegistro  ConstruirRegistroMostrar();
    }
}