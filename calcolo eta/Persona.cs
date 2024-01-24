using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcolo_eta
{
    internal class Persona
    {
        public string Nome { get; set; }

        public DateTime DataNascita { get; set; }

        public int Eta
        { get
            { int eta = DateTime.Today.Year - DataNascita.Year;
                if (DateTime.Today.Month > DataNascita.Month)
                { return eta; }
                else if (DateTime.Today.Month == DataNascita.Month)
                {
                    if (DateTime.Today.Day >= DataNascita.Day)
                    {
                        return eta;
                    }
                    else { return eta - 1; }
                    }
                //monthoggi<monthdata
                return eta-1;
                }
        }

    }
}
