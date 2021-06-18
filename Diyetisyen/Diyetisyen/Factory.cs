using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyetisyen
{
    public class Factory
    {
        public IDiyet DiyetNesnesiOlustur(string diyetTipi)
        {
            if (diyetTipi == "Akdeniz")
                return new Akdeniz();
            else if (diyetTipi == "GlutenFree")
                return new GlutenFree();
            else if (diyetTipi == "Deniz Ürünleri")
                return new DenizUrunleri();
            else return new YesilliklerDunyasi();
        }
    }
}
