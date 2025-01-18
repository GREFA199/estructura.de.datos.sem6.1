using System;

namespace Ejercicio3_BusquedaLista
{
    public class Nodo
    {
        public int Valor;
        public Nodo? Siguiente;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    public class ListaEnlazada
    {
        private Nodo? cabeza;

        public void Agregar(int valor)
        {
            if (cabeza == null)
            {
                cabeza = new Nodo(valor);
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = new Nodo(valor);
            }
        }

        public void Mostrar()
        {
            Nodo? actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        public int Buscar(int valor)
        {
            int contador = 0;
            Nodo? actual = cabeza;
            while (actual != null)
            {
                if (actual.Valor == valor)
                    contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            lista.Agregar(10);
            lista.Agregar(20);
            lista.Agregar(30);
            lista.Agregar(20);

            Console.WriteLine("Contenido de la lista:");
            lista.Mostrar();

            Console.WriteLine("Introduce un valor a buscar:");
            int valor = int.Parse(Console.ReadLine() ?? "0");
            int ocurrencias = lista.Buscar(valor);
            if (ocurrencias > 0)
            {
                Console.WriteLine($"El valor {valor} aparece {ocurrencias} veces en la lista.");
            }
            else
            {
                Console.WriteLine($"El valor {valor} no se encuentra en la lista.");
            }
        }
    }
}
