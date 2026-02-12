using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Escenario3;

namespace Presentacion.Ejecucion
{
    public class Escenario3 : IEscenario
    {
        public void Ejecutar(){
            
            Console.WriteLine("=== Aplicación de Chat Grupal ===\n");

            // Crear la sala de chat (Mediador)
            IChatMediador salaChat = new SalaChat();

            // Crear usuarios
            Usuario carlos = new UsuarioChat("Carlos", salaChat);
            Usuario anuar = new UsuarioChat("Anuar", salaChat);
            Usuario alejandro = new UsuarioChat("Alejandro", salaChat);
            Usuario jonathan = new UsuarioChat("Jonathan", salaChat);

            // Registrar usuarios en la sala    
            
            salaChat.RegistrarUsuario(carlos);
            salaChat.RegistrarUsuario(anuar);
            salaChat.RegistrarUsuario(alejandro);
            salaChat.RegistrarUsuario(jonathan);

            Console.WriteLine("\n--- Mensajes Grupales ---");
            // Enviar mensajes grupales
            carlos.Enviar("¡Hola a todos!");
            anuar.Enviar("¡Hola Carlos! ¿Cómo estás?");
            alejandro.Enviar("Buenas tardes, equipo");

            Console.WriteLine("\n--- Mensajes Privados ---");
                    
            // Enviar mensajes privados
            jonathan.EnviarPorPrivado("Carlos, ¿tienes un momento?", "Carlos");
            carlos.EnviarPorPrivado("Claro Jonathan, dime", "Jonathan");
            anuar.EnviarPorPrivado("Hola", "Carlos"); // Usuario no existe

            Console.WriteLine("\n--- Mensajes a Usuarios no existentes ---");

            jonathan.EnviarPorPrivado("Dayan, ¿estás por ahí?", "Dayan");

            Console.ReadKey();
        }
        
    }
}