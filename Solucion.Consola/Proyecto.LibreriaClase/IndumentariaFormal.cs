using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaClase.Entidades
{
    public class IndumentariaFormal:TipoIndumentaria
    {
        public IndumentariaFormal(string origen, double porcentajeAlgodon)
        {
            this.Origen = origen;
            this.PorcentajeAlgodon = porcentajeAlgodon;
        }

        public string OrigenFormal
        {
            get { return this.Origen; }
            set { this.Origen = value; }
        }

        public double PorcentajeAlgodonFormal
        {
            get { return this.PorcentajeAlgodon; }
            set { this.PorcentajeAlgodon = value; }
        }
    }
}
