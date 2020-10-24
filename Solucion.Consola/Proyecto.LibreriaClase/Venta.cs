using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    public class Venta
    {
        private List<VentaItem> _items;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;

        public Venta(int codigo, int codCliente, string apeCliente, string nomCliente)
        {
            var estadoInicial = (int).enums.EstadoVenta.Iniciada;
            this._codigo = codigo;
            this._estado = estadoInicial;
            this._items = new list<VentaItem>();
            this._cliente = new Cliente(codCliente, apeCliente, nomCliente);
        }
        public List<VentaItem> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public VentaItem BuscarPorCodigo(int codigo)
        {
            foreach (VentaItem item in _items)
            {
                if (item.Prenda.Codigo == codigo)
                {
                    return item;
                }
            } return null;
        }

        public void AgregarItems(Indumentaria indumentaria, int cantidad)
        {
            this._items.Add(new VentaItem(indumentaria, cantidad));
        }

        public double GetTotalPedido()
        {
            int cantidadVentas = this._items.Count();
            double dineroTotal = 0;
            for (int i = 0; i < cantidadVentas; i++)
            {
                dineroTotal += this._items[i].GetTotal();
            }
            return dineroTotal;
        }

        public List<Venta> GetDetalle()
        {
            List<Venta> listaVenta = new List<Venta>();
            if (this.Estado == (int)Enum.EstadoVenta.Procesada)
            {
                listaVenta.Add(string.Format("Codigo Venta: {0} - Cliente:{1} {2} {3}", this._codigo, this._cliente.Nombre, this._cliente.Apellido, this._cliente.Codigo))
            }
            else if (this.Estado ==(int)Enum.EstadoVenta.Devuelto)
            {
                listaVenta.Add(string.Format("Codigo Prenda: {0} - Cantidad{1}",AccessViolationException.Prenda.Codigo, AccessViolationException.CantidadVendida));
            }
            listaVenta.Add("");
            return listaVenta;

        }
        }
        
    }
}
