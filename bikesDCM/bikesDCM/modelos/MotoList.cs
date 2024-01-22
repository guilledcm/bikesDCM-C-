using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesDCM.modelos
{
    internal class MotoList
    {
        public List<Moto> Motos { get; set; }

        public MotoList()
        {
            Motos = new();
        }
        public bool AddMoto(Moto m)
        {
            if (!Motos.Contains(m))
            {
                Motos.Add(m);
                return true;
            }
            return false;
        }

        public bool RemoveProd(Moto m)
        {
            return Motos.Remove(m);
        }

        public Moto? GetMotoById(int Id)
        {
            foreach (Moto moto in Motos)
            {
                if (moto.Id == Id) { return moto; }
            }
            return null;
        }
    }
}
