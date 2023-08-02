using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Televisor : Electrodomestico
    {

        private double _resolucion = 20;
        private bool _tdt = false;

        // CONTRUCTOS POR DEFECTO
        public Televisor() : base () { }
        public Televisor(double precio_base, double peso) : base(precio_base, peso) { }

        public Televisor(double resolucion, bool tdt, double precio_base, Color color, double peso, char consumo_energia) :base (precio_base, peso, color, consumo_energia)
        {

            _resolucion = resolucion;
            _tdt = tdt;

        }

        // METODOS

        public override void Describir()
        {
            base.Describir();

            string mensaje_tdt = _tdt ? "SI" : "NO";
            Console.WriteLine($"\nReoslucion: {_resolucion}\nTDT: {mensaje_tdt}\n\n");


        }

        public override double Precio_final()
        {
            double precio_final = base.Precio_final();

            if (_resolucion >= 50) precio_final = precio_final * 1.3;

            if (_tdt) precio_final += 50;

            return precio_final;
        }


    }
}
