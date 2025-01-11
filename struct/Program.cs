using System;

namespace EjemploStruct
{
    public struct Rectangulo
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double x, double y, double ancho, double alto)
        {
            X = x;
            Y = y;
            Ancho = ancho;
            Alto = alto;
        }

        public double CalcularArea()
        {
            return Ancho * Alto;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Rectángulo: Posición({X}, {Y}), Ancho={Ancho}, Alto={Alto}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(5, 10, 15, 20);

            rectangulo.MostrarInfo();

            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");
        }
    }
}

/*
Diferencias clave entre struct y class:
Tipo de valor vs Tipo de referencia:

struct: Es un tipo de valor. Esto significa que cuando asignas una estructura a una nueva variable o la pasas a una función, se crea una copia completa de la estructura. Los cambios realizados en la copia no afectan al original.
class: Es un tipo de referencia. Cuando asignas un objeto de clase a una nueva variable o lo pasas a una función, lo que se pasa es una referencia al objeto, no una copia. Esto significa que los cambios realizados en un objeto afectarán a todas las variables que hacen referencia a ese objeto.
Ejemplo de diferencia:

csharp
Copiar código
struct Rectangulo
{
    public int Ancho, Alto;
}

class Program
{
    static void Main()
    {
        Rectangulo rect1 = new Rectangulo { Ancho = 5, Alto = 10 };
        Rectangulo rect2 = rect1;  // Se copia el valor
        rect2.Ancho = 20;  // No afecta a rect1

        Console.WriteLine(rect1.Ancho);  // Salida: 5
        Console.WriteLine(rect2.Ancho);  // Salida: 20
    }
}
Inmutabilidad:

struct: Aunque puedes modificar los valores de una estructura, es más eficiente para pequeños datos inmutables o datos que no se cambian a menudo. Las estructuras son más rápidas y menos costosas en términos de memoria si se usan correctamente.
class: Usualmente es más apropiada para objetos que cambian su estado o contienen lógica compleja.
Asignación de memoria:

struct: Se almacena en la pila (stack), lo que es más eficiente para estructuras pequeñas.
class: Se almacena en el montón (heap), lo que puede tener un costo más alto en términos de memoria y gestión, pero es adecuado para objetos más complejos.
Herencia:

struct: Las estructuras no pueden heredar de otras estructuras ni clases, pero pueden implementar interfaces.
class: Las clases pueden heredar de otras clases y también pueden implementar interfaces.
Valor por defecto:

struct: Tiene un valor por defecto para todos sus campos (por ejemplo, 0 para tipos numéricos).
class: Los objetos de clase se inicializan con null de forma predeterminada.
¿Cuándo usar struct en lugar de class?
Cuando estás trabajando con tipos de datos pequeños y ligeros, como puntos, coordenadas, vectores, fechas, etc.
Cuando no necesitas la herencia ni la referencia compartida.
Cuando deseas que cada instancia sea independiente y no compartas referencias (esto es útil cuando se manejan datos pequeños, como las coordenadas de un rectángulo o una fecha).
¿Cuándo usar class en lugar de struct?
Cuando necesitas mutabilidad y referencia compartida.
Cuando estás trabajando con datos más grandes o complejos.
Si necesitas usar herencia o polimorfismo.
Resumen visual de las diferencias:
Aspecto	struct	class
Tipo de valor o referencia	Valor (pasada por copia)	Referencia (pasada por referencia)
Memoria	Almacenado en la pila	Almacenado en el montón
Herencia	No soporta herencia	Soporta herencia y polimorfismo
Uso típico	Datos pequeños e inmutables	Objetos complejos y mutables
Valor por defecto	Inicialización a valores predeterminados (0, null, etc.)	Inicialización a null para objetos
Ejemplo práctico comparativo:
csharp
Copiar código
using System;

namespace EjemploClaseYStruct
{
    // Estructura (Tipo de valor)
    public struct Rectangulo
    {
        public double X, Y, Ancho, Alto;
        
        public double CalcularArea()
        {
            return Ancho * Alto;
        }
    }

    // Clase (Tipo de referencia)
    public class Coche
    {
        public string Marca;
        public double Velocidad;
        
        public void Acelerar()
        {
            Velocidad += 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Uso de struct
            Rectangulo rect1 = new Rectangulo { X = 5, Y = 5, Ancho = 10, Alto = 20 };
            Rectangulo rect2 = rect1;  // Se crea una copia
            rect2.Ancho = 15;  // Cambia solo en rect2
            Console.WriteLine($"Área del rectángulo original: {rect1.CalcularArea()}");  // 200
            Console.WriteLine($"Área del rectángulo copiado: {rect2.CalcularArea()}");  // 300

            // Uso de class
            Coche coche1 = new Coche { Marca = "Toyota", Velocidad = 100 };
            Coche coche2 = coche1;  // Apunta al mismo objeto
            coche2.Acelerar();  // Acelera coche2, pero afecta a coche1 también
            Console.WriteLine($"Velocidad del coche1: {coche1.Velocidad}");  // 110
            Console.WriteLine($"Velocidad del coche2: {coche2.Velocidad}");  // 110
        }
    }
}
Salida:
less
Copiar código
Área del rectángulo original: 200
Área del rectángulo copiado: 300
Velocidad del coche1: 110
Velocidad del coche2: 110
En este ejemplo, aunque la Rectangulo y la Coche tienen similitudes, la diferencia clave es que Rectangulo se comporta como un tipo de valor (se copia) y Coche se comporta como un tipo de referencia (la referencia se comparte entre las variables).
*/
