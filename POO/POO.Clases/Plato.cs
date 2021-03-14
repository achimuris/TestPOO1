using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Clases
{
    public class Plato
    {
        private int _cantidadDeIngredientes;

        public int CantidadDeIngredientes
        {
            get { return _cantidadDeIngredientes; }
            set { _cantidadDeIngredientes = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private double _precioBase;

        public double PrecioBase
        {
            get { return _precioBase; }
            set { _precioBase = value; }
        }

        public double getPrecio() 
        {
            double valorIngrediente = 0d;
            if (this.CantidadDeIngredientes >3)
            {
                valorIngrediente = 30 * this.CantidadDeIngredientes;
            }
            else
            {
                valorIngrediente = 20 * this.CantidadDeIngredientes;
            }

            return valorIngrediente + this.PrecioBase;
        }

        public Plato()
        {
            this.PrecioBase = 150;
        }

        public Plato(string elNombre, int cantidadIngredientes)
        {
            this.Nombre = elNombre;
            this.CantidadDeIngredientes = cantidadIngredientes;
        }

    }
}
