using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Presentacion.Ejecucion
{
      public class Escenario1: IEscenario
    {
        public void Ejecutar(){

            Console.WriteLine("=== DEMOSTRACIÓN DEL PATRÓN BUILDER ESCENARIO 1 ARQU1 ===\n");

            try
            {
                var auto1 = new Automovil.Builder()
                .Marca("Audi")
                .Motor("3.0L V6 Biturbo 355 hp")
                .ConColor("Negro mate")
                .ConLlantas("19\" deportivas")
                .ConSistemaSonido("Premium 12 bocinas Bose")
                .ConTechoSolar()
                .ConGPS()
                .ConInterior("Cuero Nappa")
                .Construir();

                Console.WriteLine("Auto completo:");
                Console.WriteLine(auto1);
                Console.WriteLine();

                var auto2 = new Automovil.Builder()
                    .Marca("Chevrolet")
                    .ConColor("Rojo Metalizado")
                    .ConTechoSolar(true)
                    .ConGPS(true)
                    .Motor("2.0L Turbo 250 hp")
                    .Construir();

                Console.WriteLine("Auto básico: ");
                Console.WriteLine(auto2);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al construir un automovil: " + ex.Message);
                
            }
        }
    }
}