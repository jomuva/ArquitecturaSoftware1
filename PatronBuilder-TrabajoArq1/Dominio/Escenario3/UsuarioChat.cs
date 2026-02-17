using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario3
{
    public class UsuarioChat : Usuario
    {
        public UsuarioChat(string nombre, IChatMediador mediador) : base(nombre, mediador)
        {
        }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"\n{Nombre} envía: {mensaje}");
            _mediador.EnviarMensaje(mensaje, this);
        }

        public override void EnviarPorPrivado(string mensaje, string nombreDestinatario)
        {
            Console.WriteLine($"\n{Nombre} envía mensaje privado a {nombreDestinatario}: {mensaje}");
            _mediador.EnviarMensajePrivado(mensaje, this, nombreDestinatario);
        }

        public override void Recibir(string mensaje, string nombreRemitente)
         {
            Console.WriteLine($"{Nombre} recibe de {nombreRemitente}: {mensaje}");
         }
    }
}