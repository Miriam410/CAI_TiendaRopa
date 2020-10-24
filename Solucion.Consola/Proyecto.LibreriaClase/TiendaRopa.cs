using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    public class TiendaRopa
    {
        private List<Indumentaria> _inventario;
        private List<Venta> _ventas;
        private int _ultimoCodigo;

        public TiendaRopa()
        {
            this._inventario = new List<Indumentaria>();
            this._ventas=new List<Venta>();
        }
        public bool InventarioVacio
        {
            get { return this._inventario.Count == 0; }
        }
        public bool SinVentas
        {
            get { return this._ventas.Count == 0; }
        }
        public List<Indumentaria> Inventario
        {
            get { return _inventario; }
            set { _inventario = value; }
        }
        public List<Venta> Ventas
        {
            get { return _ventas; }
            set { _ventas = value; }
        }

        public int UltimoCodigo
        {
            get { return _ultimoCodigo; }
            set { _ultimoCodigo = value; }
        }

        public void VenderItem(int codigoIndumentaria, int cantidad, int codCliente,
            string apeCliente, string nombCliente,)
        {
            if (!InventarioVacio)
            {
                Indumen
                if (Indumentaria.GetStockActual != 0)
                {
                  
                }
            }
        }
        public int GetProximoCodigo()
        { 
        }

        public void Agregar(Indumentaria indumentaria)
        { 
        }

        public void Modificar(Indumentaria indumentaria)
        {
        }

        public void Quitar(Indumentaria indumentaria)
        { 
        }

        public void IngresarOrden(Venta venta)
        { 
        }

        public List<Indumentaria> Listar()
        {
          
        }

        public List<Orden> ListaOrden()
        { 
        }
        public void Devolver(Orden orden)
        { 
        }


    }
}
