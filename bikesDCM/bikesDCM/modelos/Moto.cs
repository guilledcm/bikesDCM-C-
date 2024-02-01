using System;

namespace bikesDCM.modelos
{
    public class Moto
    {
        // Propiedades de la clase Moto
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public int Cilindrada { get; set; }
        public int Precio { get; set; }
        public string url_imagen { get; set; }

        // Constructor con todos los parámetros
        public Moto(int Id, string Marca, string Tipo, int Cilindrada, int Precio, string url_imagen)
        {
            this.Id = Id;
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.Cilindrada = Cilindrada;
            this.Precio = Precio;
            this.url_imagen = url_imagen;
        }

        // Constructor sin la propiedad url_imagen
        public Moto(string Marca, string Tipo, int Cilindrada, int Precio)
        {
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.Cilindrada = Cilindrada;
            this.Precio = Precio;
        }

        // Sobrescritura del método Equals para comparar motos por su Id
        public override bool Equals(object? obj)
        {
            return obj is Moto moto && Id == moto.Id;
        }

        // Sobrescritura del método GetHashCode para generar un código hash basado en el Id
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
