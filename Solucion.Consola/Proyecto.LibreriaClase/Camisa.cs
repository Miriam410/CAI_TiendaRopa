using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    public class Camisa : Indumentaria
    {
        private string _tipoManga;
        private bool _tieneEstampado;

        public string TipoManga
        {
            get { return _tipoManga; }
            set { _tipoManga = value; }
        }

        public bool TieneEstampado
        {
            get { return _tieneEstampado; }
            set { _tieneEstampado = value; }
        }

        public Camisa(int codigo, double precio, string talle, bool
            tieneEstampado, TipoIndumentaria tipoIndumentaria)
        {
            this.Codigo = codigo;
            this.Precio = precio;
            this.Talle = talle;
            this._tieneEstampado = tieneEstampado;
            this.TipoIdumentaria = tipoIndumentaria;
            this.AgregatUnidadesStock(3);
        }

        public Camisa(int codigo, double precio, string talle, bool
           tieneEstampado, TipoIndumentaria tipoIndumentaria)
        {
            this.Codigo = codigo;
            this.Precio = precio;
            this.Talle = talle;
            this._tieneEstampado = tieneEstampado;
            this.TipoIdumentaria = tipoIndumentaria;
            this.AgregatUnidadesStock(stock);
        }

        public override string GetDetalle()
        {
            if (this._tieneEstampado == false)
            {
                return string.Format("Camisa - Tipo Manga: {0} -  Codigo:{1} - Talle:{2} - Precio: ${3} -Porcentaje Algodon: {4} - Stock:{5} unidades  - Origen:{ 6}"
                     , this._tipoManga, this.Codigo, this.Talle, this.Precio, this.TipoIndumentaria.PorcentajeAlgodon, this.GetStockActual, this.TipoIndumentaria.Origen);
            }
            else
            {
                return string.Format("Camisa - Tipo Manga: {0} -  Codigo:{1} - Talle:{2} - Precio: ${3} -Porcentaje Algodon: {4} - Stock:{5} unidades  - Origen:{ 6}"
                     , this._tipoManga, this.Codigo, this.Talle, this.Precio, this.TipoIndumentaria.PorcentajeAlgodon, this.GetStockActual, this.TipoIndumentaria.Origen);
            }
        }
    }
}
