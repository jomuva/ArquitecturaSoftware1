using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario3
{
    public class SalaChat : IChatMediador
    {
        private List<Usuario> _usuarios;

        public SalaChat(){
            _usuarios= new List<Usuario>();
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
            Console.WriteLine($"[Sistema] {usuario.Nombre} se ha unido a la sala de chat.");
        }

        public void EnviarMensaje(string mensaje, Usuario remitente)
        {
            foreach (var usuario in _usuarios)
            {
                // No enviar el mensaje al remitente
                if (usuario != remitente)
                {
                    usuario.Recibir(mensaje, remitente.Nombre);
                }
            }
        }

        public void EnviarMensajePrivado(string mensaje, Usuario remitente, string nombreDestinatario)
        {
            var destinatario = _usuarios.FirstOrDefault(u => u.Nombre == nombreDestinatario);
            
            if (destinatario != null)
            {
                destinatario.Recibir($"[Privado] {mensaje}", remitente.Nombre);
                remitente.Recibir($"[Enviado a {nombreDestinatario}] {mensaje}", "Tú");
            }
            else
            {
                remitente.Recibir($"Usuario '{nombreDestinatario}' no encontrado.", "Sistema");
            }
        }
    }
}