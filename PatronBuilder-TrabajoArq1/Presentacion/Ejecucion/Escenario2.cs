using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Escenario2;

namespace Presentacion.Ejecucion
{
    public class Escenario2 : IEscenario
    {
        public void Ejecutar()
        {
            INotificacionPlataforma escritorio = new PlataformaEscritorio();
            INotificacionPlataforma movil = new PlataformaMovil();
            INotificacionPlataforma web = new PlataformaWeb();

            // 1) Misma abstracción, distinta implementación
            Notificacion alerta = new AlertNotificacion(escritorio, "Fallo de autenticación", "Intentos fallidos superan el umbral.");
            alerta.Mostrar();

            alerta.Plataforma = movil;  
            alerta.Mostrar();

            alerta.Plataforma = web;      
            alerta.Mostrar();

            // 2) Nuevo tipo de notificación sin tocar plataformas existentes
            Notificacion mensaje = new MensajeNotificacion(movil, "Soporte Mesa de Ayuda TI", "Servicio asignado.");
            mensaje.Mostrar();

            // 3) Otra abstracción
            Notificacion bien = new ConfirmacionNotificacion(escritorio, "Operación exitosa", "Los cambios se guardaron correctamente.");
            bien.Mostrar();
        }
    }
}