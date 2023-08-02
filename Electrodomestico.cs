using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Electrodomestico
    {

        public enum Color
        {
            BLANCO,
            NEGRO,
            ROJO,
            AZUL,
            GRIS
        }

        // ATRIBUTOS

        protected double precioBase;
        protected Color color;
        protected char consumoEnergetico;
        protected double peso;


        // ATRIBUTOS POR DEFECTO

        private double _precio_base = 100;
        
        private double _peso = 5;

        private Color _color = Color.BLANCO;
        
        private char _consumo_energia = 'F';
       
        public Electrodomestico()
        {
            this.precioBase = _precio_base;
            this.peso = _peso;
            this.color = _color;
            this.consumoEnergetico = _consumo_energia;

        }


        public Electrodomestico(double precio_base, double peso, Color color, char consumo_energia)
        {
            this.precioBase = precio_base;
            this.peso = peso;
            Comprobar_color(color);
            Comprobas_consumo_energetico(consumo_energia);
        }

        public Electrodomestico(double precio_base, double peso)
        {
            this.precioBase = precio_base;
            this.peso = peso;
            this.color = _color;
            this.consumoEnergetico = _consumo_energia;

        }

        // METODOS

        public virtual void Describir()
        {
            Console.WriteLine($"\n\nPrecio base: {precioBase}\nPeso: {peso}\nColor: {color}\nConsumo energia: {consumoEnergetico}\n\n");
        }

        private void Comprobas_consumo_energetico (char letra)
        {
            if (Char.ToUpper(letra) >= 'A' && Char.ToUpper(letra) <= 'F') consumoEnergetico = Char.ToUpper(letra);
            else consumoEnergetico = _consumo_energia;
        }

        private void Comprobar_color(Color color)
        {

            if (color == Color.BLANCO || color == Color.NEGRO || color == Color.ROJO || color == Color.AZUL || color == Color.GRIS) this.color = color;
            else this.color = _color;
            
        }

        public virtual double Precio_final()
        {

            double precio = 0;

            switch (this.consumoEnergetico)
            {

                case 'A':

                    precioBase += precio;

                    break;

                case 'B':

                    precio = 80;
                    precioBase += precio;

                    break;

                case 'C':

                    precio = 60;
                    precioBase += precio;

                    break;

                case 'D':

                    precio = 50;
                    precioBase += precio;

                    break;

                case 'E':

                    precio = 30;
                    precioBase += precio;

                    return precioBase;

                case 'F':

                    precio = 10;
                    precioBase += precio;

                    break;

                default:
                    break;

            }

            if (peso > 0 && peso <= 19) precioBase += 10;
            else if (peso >= 20 && peso <= 49) precioBase += 50;
            else if (peso >= 50 && peso <= 79) precioBase += 80;
            else if (peso >= 80) precioBase += 100;


            return precioBase;



        }







    }
}
