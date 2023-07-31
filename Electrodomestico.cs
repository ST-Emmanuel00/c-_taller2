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

        private double precioBase;
        private Color color;
        private char consumoEnergetico;
        private double peso;


        // ATRIBUTOS POR DEFECTO

        private double _precio_base = 100;
        
        private double _peso = 5;

        private string _color = "BLANCO";
        
        private char _consumo_energia = 'F';
       
        public Electrodomestico()
        {
            _precio_base = _precio_base;
            _peso = _peso;
            _color = _color;
            _consumo_energia = _consumo_energia;

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
            _color = _color;
            _consumo_energia = _consumo_energia;

        }

        // METODOS

        private void Comprobas_consumo_energetico (char letra)
        {
            // Verificamos que la letra esté entre A y F, en mayúsculas o minúsculas
            if (Char.ToUpper(letra) >= 'A' && Char.ToUpper(letra) <= 'F')
            {
                consumoEnergetico = Char.ToUpper(letra);
            }
            else
            {
                consumoEnergetico = _consumo_energia;
            }
        }

        public void Describir ()
        {

            Console.WriteLine($"Precio base = {precioBase}");
            Console.WriteLine($"Peso = {peso}");
            Console.WriteLine($"Color = {color}");
            Console.WriteLine($"Consumo energia = {consumoEnergetico}");


        }

        private void Comprobar_color(Color color)
        {
            if (color == Color.BLANCO || color == Color.NEGRO || color == Color.ROJO || color == Color.AZUL || color == Color.GRIS)
            {
                this.color = color;
            }
            else
            {
                this.color = Color.BLANCO;
            }
        }







    }
}
