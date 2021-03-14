using System.Collections.Generic;

namespace POO.Clases.Ejercicio02
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


        private double _precioBase = 150;

        public double PrecioBase
        {
            get { return _precioBase; }
            set { _precioBase = value; }
        }

        public double getPrecio()
        {
            double valorIngrediente = 0d;
            if (this.CantidadDeIngredientes > 3)
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

        }

        public void AgregarOpinion(int unPuntaje)
        {
            _opiniones.Add(unPuntaje);
        }

        /// <summary>
        /// Devuelve el promedio de las opiniones sobre ese plato
        /// </summary>
        /// <returns>promedio</returns>
        public double getOpinionPromedio()
        {
            double promedio = -1;

            if (this._opiniones.Count>0)
            {
                promedio = 0;
                for (int i = 0; i < this._opiniones.Count; i++)
                {
                    promedio = promedio + this._opiniones[i];
                }

                promedio = promedio / this._opiniones.Count;
            }


            return promedio;
        }

        public Plato(string elNombre, int cantidadIngredientes)
        {
            this.Nombre = elNombre;
            this.CantidadDeIngredientes = cantidadIngredientes;
        }

        private List<int> _opiniones = new List<int>();

    }
}
