using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Electrodomesticos
{
    internal class Program
    {

        public static void Resumen_totales(List<double> lista_electrodomesticos, String tipo)
        {
            if (lista_electrodomesticos.Count != 0)
            {

                double suma_total = 0;

                for (int a = 0; a < lista_electrodomesticos.Count; a++)
                {

                    suma_total += lista_electrodomesticos[a];

                }

                Console.WriteLine($"\n{tipo} registrados: {lista_electrodomesticos.Count}");
                Console.WriteLine($"Suma Total: {suma_total}");

            }

            else Console.WriteLine($"No tengo {tipo} para mostrar");

        }

        public static Electrodomestico.Color Escoger_color()
        {

            Console.WriteLine("Colores disponibles: \n");
            Console.WriteLine("1. Blanco: ");
            Console.WriteLine("2. Negro: ");
            Console.WriteLine("3. Rojo: ");
            Console.WriteLine("4. Azul: ");
            Console.WriteLine("5. Gris: ");



            Console.Write("\nEscoje un color: ");
            int op_color = int.Parse(Console.ReadLine());

            var color = Electrodomestico.Color.BLANCO;

            switch (op_color)
            {

                case 1:

                    color = Electrodomestico.Color.BLANCO;

                    return color;

                case 2:

                    color = Electrodomestico.Color.NEGRO;

                    return color;

                case 3:

                    color = Electrodomestico.Color.ROJO;

                    return color;

                case 4:

                    color = Electrodomestico.Color.AZUL;

                    return color;

                case 5:

                    color = Electrodomestico.Color.GRIS;

                    return color;



                default:
                    Console.WriteLine("No tenemos de ese color :c");
                    return color;


            }

        }
        static void Main(string[] args)
        {

            List<double> electrodomesticos = new List<double>();
            List<double> lavadoras = new List<double>();
            List<double> televisores = new List<double>();



            for (int i = 0;; i++)
            {

                // DECLARACION DE VARIABLES

                double precio, peso, precio_final, carga, resolucion;
                Electrodomestico.Color colorcito;
                char consumo;
                bool tdt = false;


                Console.WriteLine("\nSeleccione una opcion\n");

                Console.WriteLine("1. Registrar Electrodomestico general");
                Console.WriteLine("2. Registrar Lavadora");
                Console.WriteLine("3. Registrar Televisor");
                Console.WriteLine("4. Ver resumen");

                Console.WriteLine("0. Salir");

                Console.Write("\nEscoje uno: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 0) break;

                switch (opcion)
                {

                    case 1:

                        Console.WriteLine("\nEscogiste electrodomestico\n");

                        Console.Write("Precio: ");
                        precio = double.Parse(Console.ReadLine());

                        Console.Write("Peso: ");
                        peso = double.Parse(Console.ReadLine());

                        Console.Write("Color: ");

                        colorcito = Escoger_color();

                        Console.Write("\nConsumo de energia: ");

                        Console.WriteLine("\nA - B - C - D - E - F \n");

                        Console.Write("Elige un consumo: ");
                        consumo = char.ToUpper(char.Parse(Console.ReadLine()));

                        Electrodomestico electrodomestico = new Electrodomestico(precio, peso, colorcito, consumo );

                        electrodomestico.Describir();

                        precio_final = electrodomestico.Precio_final();

                        Console.WriteLine($"Precio final = {precio_final}");

                        electrodomesticos.Add(precio_final);


                        break;

                    case 2:

                        Console.WriteLine("\nEscogiste lavadora\n");

                        Console.Write("Carga: ");
                        carga = double.Parse(Console.ReadLine());

                        Console.Write("Precio: ");
                        precio = double.Parse(Console.ReadLine());

                        Console.Write("Peso: ");
                        peso = double.Parse(Console.ReadLine());

                        Console.Write("Color: ");

                        colorcito = Escoger_color();

                        Console.Write("\nConsumo de energia: ");

                        Console.WriteLine("\nA - B - C - D - E - F \n");

                        Console.Write("Elige un consumo: ");
                        consumo = char.ToUpper(char.Parse(Console.ReadLine()));

                        Lavadora Lavadora = new Lavadora(carga, precio, colorcito, peso, consumo);

                        Lavadora.Describir();

                        precio_final = Lavadora.Precio_final();

                        Console.WriteLine($"Precio final = {precio_final}");

                        electrodomesticos.Add(precio_final);
                        lavadoras.Add(precio_final);


                        break;

                    case 3:

                        Console.WriteLine("\nEscogiste televisores\n");

                        Console.Write("Resolucion: ");
                        resolucion = double.Parse(Console.ReadLine());

                        Console.Write("¿tiene TDT?: ");
                        Console.WriteLine("\n1. Si tiene");
                        Console.WriteLine("\n2. No tiene");

                        Console.Write("Escohe una opcion: ");
                        int op_tdt = int.Parse(Console.ReadLine());

                        switch (op_tdt)
                        {

                            case 1:

                                tdt = true;

                                break;

                            case 2:

                                tdt = false;

                                break;

                            default:

                                Console.WriteLine("No es valida la opcion");
                                break;

                        }

                        Console.Write("Precio: ");
                        precio = double.Parse(Console.ReadLine());

                        Console.Write("Peso: ");
                        peso = double.Parse(Console.ReadLine());

                        Console.Write("Color: ");

                        colorcito = Escoger_color();

                        Console.Write("\nConsumo de energia: ");

                        Console.WriteLine("\nA - B - C - D - E - F \n");

                        Console.Write("Elige un consumo: ");
                        consumo = char.ToUpper(char.Parse(Console.ReadLine()));

                        Televisor tv = new Televisor(resolucion, tdt, precio, colorcito, peso, consumo);

                        tv.Describir();

                        precio_final = tv.Precio_final();

                        Console.WriteLine($"Precio final = {precio_final}");

                        electrodomesticos.Add(precio_final);
                        televisores.Add(precio_final);


                        break;



                    case 4:

                        Console.WriteLine("\nResumen de electrodomesticos\n");

                        Resumen_totales(electrodomesticos, "Electrodomesticos");
                        Resumen_totales(lavadoras, "Lavadoras");
                        Resumen_totales(televisores, "Televisores");




                        break;

                    default:

                        Console.WriteLine("\nObcion no valida\n");
                        break;
                }



            }


   
           


        }
    }
}
