using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesDCM.modelos
{
    // Clase interna MotoList que representa una lista de objetos de la clase Moto
    internal class MotoList
    {
        // Propiedad que contiene la lista de motos
        public List<Moto> Motos { get; set; }

        // Constructor de la clase MotoList
        public MotoList()
        {
            // Inicializa la lista de motos
            Motos = new List<Moto>();
        }

        // Método para añadir una moto a la lista
        public bool AddMoto(Moto m)
        {
            // Verifica si la moto no está ya en la lista antes de añadirla
            if (!Motos.Contains(m))
            {
                Motos.Add(m);
                return true; // Devuelve true si la moto se añade correctamente
            }
            return false; // Devuelve false si la moto ya está en la lista
        }

        // Método para remover una moto de la lista
        public bool RemoveMoto(Moto m)
        {
            return Motos.Remove(m); // Devuelve true si la moto se remueve correctamente
        }

        // Método para obtener una moto por su Id
        public Moto? GetMotoById(int Id)
        {
            foreach (Moto moto in Motos)
            {
                if (moto.Id == Id) { return moto; } // Devuelve la moto si se encuentra por su Id
            }
            return null; // Devuelve null si no se encuentra ninguna moto con el Id proporcionado
        }
    }
}
