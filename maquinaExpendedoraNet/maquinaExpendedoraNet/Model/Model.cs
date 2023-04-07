
using System;
using System.Collections.Generic;

namespace MaquinaExpendedora.Models
{
    public class Consumable
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public object Name { get; internal set; }
        public object Price { get; internal set; }
        public object Quantity { get; internal set; }

        internal void MostrarConsumables()
        {
            throw new NotImplementedException();
        }
    }

    public class MaquinaExpendedora
    {
        public List<Consumable> Consumables { get; set; }

        public MaquinaExpendedora()
        {
            Consumables = new List<Consumable>();
            Consumables.Add(new Consumable { Nombre = "papitas", Precio = 1200, Cantidad = 7 });
            Consumables.Add(new Consumable { Nombre = "chocorramo", Precio = 2000, Cantidad = 10 });
            Consumables.Add(new Consumable { Nombre = "chiclets", Precio = 800, Cantidad = 22 });
        }

        public void AgregarConsumable(Consumable Consumable)
        {
            Consumables.Add(Consumable);
        }

        public void EliminarConsumable(Consumable Consumable)
        {
            Consumables.Remove(Consumable);
        }

        public void MostrarConsumables()
        {
            foreach (Consumable Consumable in Consumables)
            {
                System.Console.WriteLine(Consumable.Nombre + " - $" + Consumable.Precio + " - Cantidad: " + Consumable.Cantidad);
            }
        }
    }
}

//Sebastian Ortiz