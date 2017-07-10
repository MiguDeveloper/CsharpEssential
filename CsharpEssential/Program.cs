using System;

namespace CsharpEssential
{
    //Creamos el enum, lo declaramos fuera de las clases para que cualquier clase lo pueda usar
    public enum MesesDelAnio
    {
        Enero = 1,
        Febrero,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Setiembre,
        Octubre,
        Noviembre,
        Diciembre
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            /* C# es fuertemente tipado, cada variable y cada constante va a tener un tipo
             * la informacion que contiene un tipo es 
             * - Espacio de memoria
             * - Valores
             * - El tipo base del cual hereda
             * - Operaciones permitidas
             * - Dirección de memoria en tiempo de ejecución.
             */

            //DECLARACIÓN DE VARIABLES

            //variable Explicita
            string nombre = "Miguel";

            /* Variable Implicito:
             * el compilador se encarga de definir su tipo teniendo en
             * cuenta el valor que le asigenemos. e.g. la variable edad es de tipo Real-Double
             */
            var edad = 16.7;

            //SALIDA POR CONSOLA
            /* comando para mostrar datos en consola
             * int numx = 1;
             * int numy = 2;
             * int total = numx + numy;
             * Console.WriteLine("{0} + {1} = {2}", numx, numy, total);
             */
            Console.WriteLine("Este es un mensaje de salida!");

            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("tu nombre es: " + nombre + ",Tu edad es :" + edad);

            //TIPO DE DATOS INTEGRADOS

            /* Existen diferente tipos de datos e.g. byte, Int, short, long, float, double, decimal; char, string; object
             * tomar en cuenta que  para los de coma flotante como double, float y decimal solo para estos
             * dos últimos usar la siguiente convención:
             * float mi_numero = 123.23f;
             * decimal mi_decimal = 123.23m; usado para datos financieros
             * 
             * El byte tiene un rango de 0 y 255
             * byte dias_semana = 7;
             * 
             * Los de tipo cadena
             * string: representa cadena de texto
             * char: representa unicamente un caracter
             */
            string mi_cadena = "Probando tipo cadena";
            char mi_char = mi_cadena[0];

            Console.WriteLine("Cadena completa: '" + mi_cadena + "', el primer caracter es: " + mi_char);

            //CONSTANTES E IDENTIFICADORES

            /* la constante no cambia y se declara de manera similar a una variable
             * const int horas_dia = 24;
             * en caso yo quiera cambiarle el valor c# me dara un error ya que el valor de la constante no va a cambiar.
             * 
             * Identificadores: son palabras clave o reservadas e.g.: int, static namespace, using, etc.
             * 
             * TIPO DE DATO NULL
             * Variables que soporte un Null e.g.:
             * bool? miBandera = null;
             * int? miNumero = null;
             * 
             * TIPO DE DATO ENUM
             * C# permite crear un conjunto propio de constantes con nombre utilizando la palabra clave enum. 
             * Estos tipos de datos permiten declarar un conjunto de nombres u otros valores literales que definen 
             * todos los valores posibles que se pueden asignar a una variable.
             * Por ejemplo, si el programa utiliza los días de la semana, es posible crear un nuevo tipo 
             * llamado DayOfWeek. Se puede declarar una nueva variable del tipo DayOfWeek y 
             * asignarle un valor. La utilización de este tipo de datos permite que el código 
             * sea más legible y hace menos probable que se asigne a la variable un valor no válido o inesperado.
             * 
             */

            //Usamos el enum
            Console.WriteLine("Mes actual '" + MesesDelAnio.Julio + "'");
            int indiceEnum = (int)MesesDelAnio.Julio;
            //mostramos su indice
            Console.WriteLine("Indice del mes: " + indiceEnum);

            //OPERADORES

            /* ASIGNACIÓN usamos el '=' e.g. 
             * int num = 12;
             * conbinacines +=, -=, *=
             * 
             * RELACIONALES <,<=,>,>=, ==, !=
             * 
             * LÓGICOS &&, ||, !
             * bool boleana = false;
             * bool newBoleana = !boleana;
             */


            //CONDICIONES Y SENTENCIAS
            // IF ELSE
            int num1 = 3;
            int num2 = 2;
            if (num1 > num2)
            {
                Console.WriteLine("num1 mayor a num2");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("num2 mayor a num1");
            }

            //SWITCH
            switch (num1)
            {
                case 1:
                    num2 += 1;
                    break;
                case 2:
                    num2 += 2;
                    break;
                case 3:
                    num2 += 3;
                    break;
                default:
                    Console.WriteLine("no coincide");
                    break;

            }
			
            Console.ReadKey();
        }
    }
}
