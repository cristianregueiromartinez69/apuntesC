using System;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}";
    }

      public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Persona otraPersona = (Persona)obj;
        return Nombre == otraPersona.Nombre && Edad == otraPersona.Edad;
    }

     public override int GetHashCode()
    {
        return Nombre.GetHashCode() ^ Edad.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Persona personaToString = new Persona { Nombre = "Carlos", Edad = 30 };
        Console.WriteLine(personaToString.ToString()); 

        Persona persona1 = new Persona { Nombre = "Carlos", Edad = 30 };
        Persona persona2 = new Persona { Nombre = "Carlos", Edad = 30 };
        Persona persona3 = new Persona { Nombre = "Ana", Edad = 25 };

        Console.WriteLine(persona1.Equals(persona2)); 
        Console.WriteLine(persona1.Equals(persona3)); 
    }
}


/*
Resumen:
ToString(): Convierte un objeto en una representación de cadena legible.
Equals(): Compara si dos objetos son equivalentes (según tu lógica).
GetHashCode(): Devuelve un código hash único para un objeto, usado principalmente en colecciones como HashSet y Dictionary.
*/