using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    class VentaItem
    {
        private Indumentaria _prenda;
        private int _cantidad;

        public Indumentaria Prenda
        {
            get { return this._prenda; }
        }

        public int CantidaVentida
        {
            get { return this._cantidad; }
        }

        public VentaItem(Indumentaria indumentaria, int cantidad)
        {
            this._prenda = indumentaria;
            this._cantidad = cantidad;
        }

        public double GetTotal()
        {
            return this._prenda.Precio * this._cantidad;
        }
        public override string ToString()
        {
            return _prenda.GetDetalle();
        }
    }
}
