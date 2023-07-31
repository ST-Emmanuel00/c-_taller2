using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Electrodomesticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        Electrodomestico electrodomestico = new Electrodomestico(600, 20, Electrodomestico.Color.ROJO, 'B');
            //Electrodomestico electrodomestico_defecto = new Electrodomestico();
            //Electrodomestico electrodomestico2 = new Electrodomestico(200, 7);

            

            electrodomestico.Describir();
            //electrodomestico2.Describir();
            //electrodomestico_defecto.Describir();


        }
    }
}
