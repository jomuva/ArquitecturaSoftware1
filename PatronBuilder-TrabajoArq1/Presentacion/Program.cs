using Dominio;

Console.WriteLine("=== DEMOSTRACIÓN DEL PATRÓN BUILDER ESCENARIO 1 ARQU1 ===\n");

var auto1 = new Automovil.Builder()
    .ConMotor("3.0L V6 Biturbo 355 hp")
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
    .ConColor("Rojo Metalizado")
    .ConTechoSolar(true)
    .Construir();

Console.WriteLine("Auto básico:");
Console.WriteLine(auto2);