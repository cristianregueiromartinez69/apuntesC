using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listaNumeros = new List<int>();

        listaNumeros.Add(10);
        listaNumeros.Add(20);
        listaNumeros.Add(30);

        listaNumeros.AddRange(new int[] { 40, 50, 60 });

        Console.WriteLine("Elemento en índice 2: " + listaNumeros[2]); 

        listaNumeros.Remove(20);

        listaNumeros.RemoveAt(0);  

        Console.WriteLine("Elementos en la lista:");
        foreach (var numero in listaNumeros)
        {
            Console.WriteLine(numero);         }

        Stack<int> pila = new Stack<int>();

        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        Console.WriteLine("Elemento en la cima de la pila: " + pila.Peek());  

        Console.WriteLine("Elemento retirado: " + pila.Pop()); 

        Console.WriteLine("Elementos restantes en la pila:");
        foreach (var numero in pila)
        {
            Console.WriteLine(numero);  
        }

        Queue<int> cola = new Queue<int>();

        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        Console.WriteLine("Elemento en el frente de la cola: " + cola.Peek());  // Salida: 10

        Console.WriteLine("Elemento retirado: " + cola.Dequeue());  // Salida: 10

        Console.WriteLine("Elementos restantes en la cola:");
        foreach (var numero in cola)
        {
            Console.WriteLine(numero); 
        }
    }
}






/*
Listas
Métodos más importantes:
Add: Añade un elemento al final de la lista.
AddRange: Añade un rango de elementos a la lista.
RemoveAt: Elimina un elemento en un índice específico.
Remove: Elimina la primera aparición de un elemento específico.
Count: Devuelve el número de elementos en la lista.
*/

/*
Pilas: 
Métodos más importantes:
Push: Añade un elemento al final de la pila.
Pop: Elimina y devuelve el último elemento añadido.
Peek: Devuelve el último elemento añadido sin eliminarlo.
Count: Devuelve el número de elementos en la pila.
*/

/*
Colas: 
Métodos más importantes:
Enqueue: Añade un elemento al final de la cola.
Dequeue: Elimina y devuelve el primer elemento añadido.
Peek: Devuelve el primer elemento sin eliminarlo.
Count: Devuelve el número de elementos en la cola.
*/