using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo1
{
    public class ListaProductos
    {
        NodoProducto raiz, nuevo, ptr, ant;
        // METODO CONSTRUCTOR 
        public ListaProductos()
        {
            raiz = null;
        }
        // METODO INSERTAR 
        public void Insertar(Productos dato)
        {
            nuevo = new NodoProducto();
            nuevo.info = dato;
            if (raiz == null)
                nuevo.sig = null;
            else
                nuevo.sig = raiz;
            raiz = nuevo;
        }
        // METODO LISTAR 
        public void Listar()
        {
            Console.WriteLine("\n---LISTADO DE PRODUCTOS---");
            ptr = raiz;
            while (ptr != null)
            {
                Console.WriteLine("\n{0} {1} {2} {3} {4}",
                    ptr.info.IdProducto,
                    ptr.info.Descripcion,
                    ptr.info.Stock,
                    ptr.info.Precio,
                    ptr.info.Estado);
                ptr = ptr.sig;
            }
        }
        // METODO BUSCAR 
        public void Buscar(int IdProducto)
        {

            bool encontrado = false;
            ptr = raiz;
            while (ptr != null && !encontrado)
            {
                if (ptr.info.IdProducto == IdProducto)
                {
                    encontrado = true;
                    Console.WriteLine("\n PRODUCTO ENCONTRADO: {0}, {1}, {2}, {3}, {4}",
                        ptr.info.IdProducto,
                        ptr.info.Descripcion,
                        ptr.info.Stock,
                        ptr.info.Precio,
                        ptr.info.Estado);
                }
                ptr = ptr.sig;
            }
            if (!encontrado)
                Console.WriteLine("\n{0}, PRODUCTO NO ENCONTRADO", IdProducto);
        }
        // METODO ELIMINAR 
        public void Eliminar(int IdProducto)
        {
            bool encontrado = false;
            if (ptr != null && raiz.info.IdProducto == IdProducto)
            {
                raiz = raiz.sig;
                encontrado = true;
            }
            else
            {
                ptr = ant = raiz;
                while (ptr != null && !encontrado)
                {
                    if (ptr.info.IdProducto == IdProducto)
                    {
                        ant.sig = ptr.sig;
                        encontrado = true;
                    }
                    ant = ptr;
                    ptr = ptr.sig;
                }
                Console.WriteLine("\n{0}, PRODUCTO {1}", IdProducto, (encontrado ? "ELIMINADO" : "NO ENCONTRADO"));
            }
        }
        // METODO ORDENAR 
        public void Ordenar()
        {
            ptr = raiz;
            while (ptr != null)
            {
                ant = ptr.sig;
                while (ant != null)
                {
                    if (ptr.info.IdProducto > ant.info.IdProducto)
                    {
                        Productos aux = ptr.info;
                        ptr.info = ant.info;
                        ant.info = aux;
                    }
                    ant = ant.sig;
                }
                ptr = ptr.sig;
            }

        }
    }
}
