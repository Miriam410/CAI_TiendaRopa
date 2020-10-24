using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    public abstract class Indumentaria
    {
        private TipoIndumentaria _tipoIndumentaria;
        protected int _codigo;
        protected int _stock;
        protected string _talle;
        protected double _precio;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public int GetStockActual
        {
            get { return this._stock; }

        }
        public void AgregarUnidadStock(int stockAgregado)
        {
            this._stock += stockAgregado;
        }

        public void RestarUnidadesStock(int stockRestado)
        {
            this._stock -= stockRestado;
        }
        public string Talle
        {
            get { return _talle; }
            set { _talle = value; }
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public override string ToString()
        {
            return GetDetalle();
        }

        public abstract string GetDetalle();
        public override bool Equals(object obj)
        {
            Indumentaria indumentaria = (Indumentaria)obj;
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Camisa))
            {
                return false;
            }
            return this._codigo == indumentaria.Codigo;
        }

      
    }
}
