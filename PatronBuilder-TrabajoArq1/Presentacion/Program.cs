
using Presentacion.Ejecucion;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║     MENÚ DE ESCENARIOS                 ║");
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║ 1. Ejecutar Escenario 1                ║");
            Console.WriteLine("║ 2. Ejecutar Escenario 2                ║");
            Console.WriteLine("║ 3. Ejecutar Escenario 3                ║");
            Console.WriteLine("║ 4. Salir                               ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("\nSeleccione una opción: ");

            string opcion = Console.ReadLine();

            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    EjecutarEscenario(new Escenario1(), "Escenario 1");
                    break;
                case "2":
                    EjecutarEscenario(new Escenario2(), "Escenario 2");
                    break;
                case "3":
                    EjecutarEscenario(new Escenario3(), "Escenario 3");
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("¡Cerrando Ejecucion!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

            if (continuar && opcion != "4")
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }

    static void EjecutarEscenario(IEscenario escenario, string nombre)
    {
        Console.WriteLine($"═══ Ejecutando {nombre} ═══\n");
        try
        {
            escenario.Ejecutar();
            Console.WriteLine($"\n✓ {nombre} ejecutado exitosamente");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n Error al ejecutar {nombre}: {ex.Message}");
        }
    }
}