using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Electrodomesticos.Electrodomestico;

namespace Electrodomesticos
{
    internal class Lavadora : Electrodomestico
    {

        private double _carga = 5;

        // CONSTRUCTOR POR DEFECTO
        public Lavadora() : base () { }

        public Lavadora(double precio_base, double peso ) : base( precio_base, peso ) { }

        public Lavadora(double carga, double precio_base, Color color, double peso, char consumo_energia) : base(precio_base, peso, color , consumo_energia)
        {
            _carga = carga;
        }

        // METODOS
        public override void Describir()
        {

            Console.WriteLine($"\n\nPrecio base: { base.precioBase}\nPeso: {base.peso}\nColor: {base.color}\nConsumo energia: {base.consumoEnergetico}\nCarga: {_carga} \n\n");

        }

        public override double Precio_final()
        {

            double precio_base_lavadora = base.Precio_final();

            if (_carga > 30) precio_base_lavadora += 50;

            return precio_base_lavadora;


        }

    }
}
