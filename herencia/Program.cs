using System;

class Animal
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

class Perro : Animal
{
    public string Raza { get; set; }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau!");
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro();
        miPerro.Nombre = "Fido";
        miPerro.Raza = "Labrador";

        miPerro.Comer();               
        miPerro.HacerSonido();         

        Animal miAnimal = new Animal();
        miAnimal.Nombre = "Animal Genérico";
        miAnimal.Comer();              
        miAnimal.HacerSonido();        
    }
}

/*
virtual:

La palabra clave virtual indica que el método puede ser sobrescrito (es decir, redefinido) en una clase que herede de esta clase.
Esto permite que las clases derivadas (como Perro en el ejemplo) proporcionen su propia implementación para este método, si así lo desean.
Si una clase no sobrescribe este método, se usará la implementación por defecto, que es la que se muestra en el código: Console.WriteLine("El animal hace un sonido.");.
*/