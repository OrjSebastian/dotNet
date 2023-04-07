using System;

namespace MaquinaExpendedora.Views
{
    public class Vista
    {
        public void MostrarMenuPrincipal()
        {
            Console.WriteLine("Bienvenido a la máquina expendedora");
            Console.WriteLine("1. Mostrar Productos");
            Console.WriteLine("2. Agregar Producto");
            Console.WriteLine("3. Eliminar Producto");
            Console.WriteLine("4. Salir");
        }

        public void MostrarConsumables()
        {
            Console.WriteLine("Consumables disponibles:");
        }

        public void MostrarStockConsumable(Models.Consumable Consumable)
        {
            Console.WriteLine("El Consumable " + Consumable.Nombre + " tiene un precio de $" + Consumable.Precio + " y un stock de " + Consumable.Cantidad);
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}

//Sebastian Ortiz