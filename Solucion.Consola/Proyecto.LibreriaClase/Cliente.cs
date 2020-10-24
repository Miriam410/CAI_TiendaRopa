using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase
{
    public class Cliente
    {
        private int _codigo;
        private string _nombre;
        private string _apellido;

        public int Codigo
        {
            get { return _codigo; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public string Apellido
        {
            get { return _apellido; }
        }

        public Cliente(int codigo, string apellido, string nombre)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}
