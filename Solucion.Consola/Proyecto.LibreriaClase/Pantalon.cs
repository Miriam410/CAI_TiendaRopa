using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    public class Pantalon : Indumentaria
    {
        private string _material;
        private bool _tieneBolsillo;

        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public bool TieneBolsillos
        {
            get { return _tieneBolsillo; }
            set { _tieneBolsillo = value; }
        }

        public override string ToString()
        {
            return GetDetalle();
        }

        public Pantalon(int codigo, double precio, string talle, bool
            tieneBolsillo, string material, TipoIndumentaria tipoIndumentaria)
        {
            this.Codigo = codigo;
            this.Precio = precio;
            this.Talle = talle;
            this._tieneBolsillo = tieneBolsillo;
            this.TipoIdumentaria = tipoIndumentaria;
            this.AgregatUnidadesStock(3);
        }
        public Pantalon(int codigo, double precio, string talle, bool
            tieneBolsillo, string material, TipoIndumentaria tipoIndumentaria)
        {
            this.Codigo = codigo;
            this.Precio = precio;
            this.Talle = talle;
            this._tieneBolsillo = tieneBolsillo;
            this.TipoIdumentaria = tipoIndumentaria;
            this.AgregatUnidadesStock(stock);
        }

        public override string GetDetalle()
        {
            if (this._tieneBolsillo == false)
            {
                return string.Format("Pantalon -Material: {0} -  Codigo:{1} - Talle:{2} - Precio: ${3} -Porcentaje Algodon: {4} - Stock:{5} unidades  - Origen:{ 6}"
                    , this.Material, this.Codigo, this.Talle, this.Precio, this.TipoIndumentaria.PorcentajeAlgodon, this.GetStockActual, this.TipoIndumentaria.Origen);
            }
            else
            {
                return string.Format("Pantalon con Bolsillo -Material: {0} -  Codigo:{1} - Talle:{2} - Precio: ${3} -Porcentaje Algodon: {4} - Stock:{5} unidades  - Origen:{ 6}"
                    ,this.Material, this.Codigo, this.Talle, this.Precio, this.TipoIndumentaria.PorcentajeAlgodon, this.GetStockActual, this.TipoIndumentaria.Origen);
            }
        }
    }
}
