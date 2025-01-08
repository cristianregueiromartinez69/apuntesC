class Program{

    static void Main(string [] args){
        //operadores de incremento
        int number = 0;
        number += 2;
        number -= 2

        //&&(AND)
        //||(OR)
        //typeOf -> tipo de variable
        // == -> igual igual a
        // >= -> mayor igual que
        // <= ->  menor igual que
        // > -> mayor que
        // < ->  menor que

    }

    static void declarations(){
        //declaracion de variables
        int number = 0;
        double numberDecimals = 0.0d;
        bool yayOrNay = true;
    }


}

/*
Operadores
Los operadores usados en C# son similares a otros lenguajes de programación.

Aquí puedes ver la lista completa

Pero mencionaremos los más comunes.

= Asignación
+= Incremento y asignación
-= Decremento y asignación
== Igual
!= Distinto
> Mayor qué
>= Mayor o igual que
< Menor que
<= Menor o igual que
&& Y (And)
|| O (Or)
typeof Devuelve el tipo

Estructuras condicionales
Como en otros lenguajes de programación la palabra clave que se usa para la estructura condicional es if además de poder introducir otras condiciones
usando else if o la posibilidad de que ninguna condición funcione con else

Esta estructura SIEMPRE debe devolver un valor booleano.


int number = 5;

if(number == 5) //El operador == devuelve un booleano
{

}
Estructuras de control complejas (Bucles)
Para las estructuras de control complejas, es decir, bucles. Tenemos también las condiciones que normalmente trabajamos:

For

for(int i = 0; i < 10; i++) //Un bucle for que repetirá hasta 10
{}
While

bool continue = true;

while(continue == true) //Siempre debe tener un valor condicional.
{
//Ejecutamos hasta que el valor de continue sea false.
}
For each
Nos permite recorrer colecciones que veremos más adelante.


int[] numbers = {3,4,5};

for each(int number in numbers)
{
    //La variable number tendrá los valores 3,4,5 respectivamente.
}
*/