using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario3
{
    public interface IChatMediador
    {
        void RegistrarUsuario(Usuario usuario);
        void EnviarMensaje(string mensaje, Usuario remitente);
        void EnviarMensajePrivado(string mensaje, Usuario remitente, string nombreDestinatario);
    }
}