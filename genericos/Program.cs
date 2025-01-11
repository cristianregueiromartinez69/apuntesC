using System;

public class Caja<T> 
{
    private T elemento;

    public void GuardarElemento(T item)
    {
        elemento = item;
    }

    public T ObtenerElemento()
    {
        return elemento;
    }
}

class Program
{

    public static void Intercambiar<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Caja<int> cajaEntero = new Caja<int>();
        cajaEntero.GuardarElemento(123);
        Console.WriteLine(cajaEntero.ObtenerElemento());  

        Caja<string> cajaCadena = new Caja<string>();
        cajaCadena.GuardarElemento("Hola Mundo");
        Console.WriteLine(cajaCadena.ObtenerElemento()); 

        int x = 5, y = 10;
        Console.WriteLine($"Antes: x = {x}, y = {y}");
        Intercambiar(ref x, ref y);
        Console.WriteLine($"Después: x = {x}, y = {y}");

        string a = "Hola", b = "Mundo";
        Console.WriteLine($"Antes: a = {a}, b = {b}");
        Intercambiar(ref a, ref b);
        Console.WriteLine($"Después: a = {a}, b = {b}"); 
    }
}
