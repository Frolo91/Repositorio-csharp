using System;

namespace Extraer_contar_y_almacenar_palabras_de_un_txt_en_un_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palabras encontradas en el .TXT");
          
            string oracion = System.IO.File.ReadAllText(@"D:\Carpeta de Pruebas Visual_estudio\prueba.txt");
            int cont = 1; // para contar el 3 espacio se cmienza en 1

            for (int i = 0; i < oracion.Length; i++)
            {
                if (oracion[i] == ' ' && oracion[i + 1] != ' ') // en caso de encontrar dos seguidos solo tome 1
                {
                    cont++; // este for es para definir el tamaño del contenedor de las palabras encontradas
                }
            }
            String[] palabras = new string[cont];
            int ind1 = 0;  //|el indice desde donde se cortara la palabra con substring()
            int contp = 0; //|contador que me va a recorrer el contenedor de palabras 

            for (int i = 0; i < oracion.Length; i++)//|volvemos a recorrer a oracion
            {                                       //|esta vez para cortar las palabas con el substring() 
                                                    //|y almacenarlas en el contenedor
                if (oracion[i] == ' ' && oracion[i + 1] != ' ')
                {
                    palabras[contp] = oracion.Substring(ind1, (i - ind1));// substring(indice,longitud)
                    ind1 = i + 1;
                    contp++; //|cada vez que se cumpla la condicion y se asigne la palabra al contenedor 
                }            //|pasamos a a siguiente posicion 
                else
                    if (oracion.Length == (i + 1)) //|if-else para tomar el ultimo fragmento de la oracion 
                {                                //|no entrara al 1er for mas de 2 veces por la cantidad de espacios 
                    palabras[contp] = oracion.Substring(ind1, (oracion.Length - ind1));
                }

            }
            Console.WriteLine();
            for (int i = 0; i < palabras.Length; i++) // Recorremos el contenedor e imprimimos 
            {

                Console.WriteLine(palabras[i]);// Recorremos el contenedor e imprimimos 

            }
            Console.WriteLine();
            Console.WriteLine("la cantidad de palabras es:{0}", cont);
        }
    }
}
