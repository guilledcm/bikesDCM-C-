using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesDCM.modelos
{
    internal class Moto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public int Cilindrada { get; set; }
        public int Precio { get; set; }
        public string url_imagen {  get; set; }
        public Moto(int Id, string Marca, string Tipo, int Cilindrada, int Precio, string url_imagen)
        {
            this.Id = Id;
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.Cilindrada = Cilindrada;
            this.Precio = Precio;
            this.url_imagen = url_imagen;
        }
        public override bool Equals(object? obj)
        {
            return obj is Moto moto &&
                   Id == moto.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
