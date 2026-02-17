using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Escenario3
{
    public  abstract class Usuario
    {
        protected IChatMediador _mediador;
        public string Nombre { get; private set; }

        public Usuario(string nombre, IChatMediador mediador)
        {
            Nombre = nombre;
            _mediador = mediador;
        }

        public abstract void Enviar(string mensaje);
        public abstract void EnviarPorPrivado(string mensaje, string nombreDestinatario);
        public abstract void Recibir(string mensaje, string nombreRemitente);

    }
}