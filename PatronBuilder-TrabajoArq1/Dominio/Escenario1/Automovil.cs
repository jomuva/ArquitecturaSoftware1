using System;


namespace Dominio
{
    public class Automovil
    {
        public string Marca { get; }
        public string Motor { get; }
        public string Color { get; }
        public string Llantas { get; }
        public string SistemaSonido { get; }
        public bool TechoSolar { get; }
        public bool GPS { get; }
        public string TipoInterior { get; }

        private Automovil(Builder builder)
        {
            Marca = builder._marca ?? "Ford";
            Motor = builder._motor ?? throw new ArgumentException("El motor de la marca "+ builder._marca + " es obligatorio");
            Color = builder._color ?? "Blanco Perla";
            Llantas = builder._llantas ?? "17\" Aleación";
            SistemaSonido = builder._sistemaSonido ?? "Estándar 6 parlantes";
            TechoSolar = builder._techoSolar;
            GPS = builder._gps;
            TipoInterior = builder._interior ?? "Tela";
        }

        public override string ToString()
        {
            return
                $"Configuración del vehículo:\n" +
                $"  Marca:           {Marca}\n" +
                $"  Motor:           {Motor}\n" +
                $"  Color:           {Color}\n" +
                $"  Llantas:         {Llantas}\n" +
                $"  Sistema de sonido: {SistemaSonido}\n" +
                $"  Techo solar:     {(TechoSolar ? "Sí" : "No")}\n" +
                $"  GPS:             {(GPS ? "Sí" : "No")}\n" +
                $"  Interior:        {TipoInterior}";
        }

        public class Builder
        {
            internal string? _marca;
            internal string? _motor;
            internal string? _color;
            internal string? _llantas;
            internal string? _sistemaSonido;
            internal bool _techoSolar;
            internal bool _gps;
            internal string? _interior;

            public Builder Marca(string marca) { _marca = marca; return this; }
            public Builder Motor(string motor) { _motor = motor; return this; }
            public Builder ConColor(string color) { _color = color; return this; }
            public Builder ConLlantas(string llantas) { _llantas = llantas; return this; }
            public Builder ConSistemaSonido(string sistema) { _sistemaSonido = sistema; return this; }
            public Builder ConTechoSolar(bool tiene = true) { _techoSolar = tiene; return this; }
            public Builder ConGPS(bool tiene = true) { _gps = tiene; return this; }
            public Builder ConInterior(string interior) { _interior = interior; return this; }

            public Automovil Construir() => new Automovil(this);
        }
    }
}
