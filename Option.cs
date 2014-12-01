using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Option : Ordinateur
    {
        protected Ordinateur ordi;
    protected double tarifExtension;
    public Option(Ordinateur ordinateur, double tarif)
    {
        ordi = ordinateur;
        tarifExtension = tarif;
    }
    public override double prix
    {
        get { return ordi.prix + tarifExtension; }
    }
    }
}
