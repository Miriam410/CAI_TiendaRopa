using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    public abstract class TipoIndumentaria
    {
        private string _origen;
        private double _porcentajeAlgodon;

        public string Origen
        {
            get { return _origen; }
            set { _origen = value; }
        }

        public double PorcentajeAlgodon
        {
            get { return _porcentajeAlgodon; }
            set { _porcentajeAlgodon = value; }
        }
    }
}
