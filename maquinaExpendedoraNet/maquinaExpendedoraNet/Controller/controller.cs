using System;
using System.Collections.Generic;
using MaquinaExpendedora.Models;
using MaquinaExpendedora.Views;

namespace MaquinaExpendedora.Controllers
{

    public class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            var isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Maquina expendedora");
                Console.WriteLine("¿Eres cliente o proveedor? (C/P)");
                var role = Console.ReadLine().ToLower();

                switch (role)
                {
                    case "c":
                        Console.WriteLine("Opciones cliente:");
                        Console.WriteLine("1. Comprar");
                        Console.WriteLine("2. Salir");
                        var customerOption = Console.ReadLine();

                        switch (customerOption)
                        {
                            case "1":
                                Console.WriteLine("Productos disponibles:");
                                if (products.Count > 0)
                                {
                                    foreach (var product in products)
                                    {
                                        Console.WriteLine($"{product.Name} - ${product.Price} - Disponibles: {product.Quantity}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay Productos disponibles.");
                                }
                                break;

                            case "2":
                                isRunning = false;
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                        break;

                    case "p":
                        Console.WriteLine("Opciones proveedor:");
                        Console.WriteLine("1. Mostrar Productos");
                        Console.WriteLine("2. Agregar Productos");
                        Console.WriteLine("3. Eliminar Productos");
                        Console.WriteLine("4. Salir");
                        var providerOption = Console.ReadLine();

                        switch (providerOption)
                        {
                            case "1":
                                Console.WriteLine("Productos disponibles:");
                                if (products.Count > 0)
                                {
                                    foreach (var product in products)
                                    {
                                        Console.WriteLine($"{product.Name} - ${product.Price} - Disponibles: {product.Quantity}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay Productos disponibles.");
                                }
                                break;

                            
                            case "2":
                                Console.WriteLine("Ingrese el nombre del nuevo Producto o el nombre del Producto a actualizar:");
                                var productName = Console.ReadLine();
                                Console.WriteLine("Ingrese el precio del producto:");
                                var productPrice = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la cantidad de unidades disponibles del Producto:");
                                var productQuantity = int.Parse(Console.ReadLine());

                                var existingProduct = products.Find(product => product.Name == productName);

                                if (existingProduct == null)
                                {
                                    // Agregar un nuevo producto
                                    products.Add(new Product { Name = productName, Price = productPrice, Quantity = productQuantity });
                                    Console.WriteLine($"Producto {productName} agregado exitosamente.");
                                }
                                else
                                {
                                    // Actualizar un producto existente
                                    existingProduct.Price = productPrice;
                                    existingProduct.Quantity = productQuantity;
                                    Console.WriteLine($"Producto {productName} actualizado exitosamente.");
                                }
                                break;

                            case "3":
                                Console.WriteLine("Ingrese el nombre del producto que desea eliminar:");
                                var productToDelete = Console.ReadLine();
                                var productFound = false;

                                foreach (var product in products)
                                {
                                    if (product.Name == productToDelete)
                                    {
                                        products.Remove(product);
                                        Console.WriteLine($"Producto {productToDelete} eliminado exitosamente.");
                                        productFound = true;
                                        break;
                                    }
                                }

                                if (!productFound)
                                {
                                    Console.WriteLine($"Producto {productToDelete} no encontrado.");
                                }
                                break;

                            case "4":
                                isRunning = false;
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Rol no válido.");
                        break;
                }
            }

            Console.WriteLine("¡Gracias por utilizar la tienda en línea!");
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

//Sebastian Ortiz
