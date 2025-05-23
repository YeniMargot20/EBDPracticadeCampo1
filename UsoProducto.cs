﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo1
{
    public class UsoProducto
    {
        static void Main()
        {
            ListaProductos lista = new ListaProductos();
            // AÑADIR PRODUCTOS
            lista.Insertar(new Productos(100, "Laptop hp", 10, 3500, true));
            lista.Insertar(new Productos(200, "Laptop Lenovo", 10, 2400, true));
            lista.Insertar(new Productos(300, "Laptop Dell", 10, 4400, true));
            lista.Insertar(new Productos(400, "Laptop Asus", 10, 3400, true));
            lista.Insertar(new Productos(500, "Laptop Apple", 10, 5400, true));
            //LISTAR PRODUCTOS 
            lista.Listar();
            // BUSCAR PRODUCTO
            Console.WriteLine("\n--- BUSQUEDA DE PRODUCTO---");
            lista.Buscar(200);
            lista.Buscar(700);
            // ELIMINAR PRODUCTO
            Console.WriteLine("\n--- ELIMINAR PRODUCTO ---");
            lista.Eliminar(300);
            lista.Listar();
            // ORDENAR PRODUCTOS
            Console.WriteLine("\n--- ORDENAR PRODUCTOS ---");
            lista.Ordenar();
            lista.Listar();
            Console.ReadLine();

        }
    }
}
