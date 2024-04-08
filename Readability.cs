using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cs50;

public class Readability
{



    //Funcion principal


    // Define la función principal
    // Inicio del Programa
    //     Pedir al usuario que ingrese un texto
    //     Si el texto está vacío
    //         Mostrar mensaje de error y terminar
    //     Fin si

    //     Calcular el número de letras usando la función CountLetters
    //     Calcular el número de palabras usando la función CountWords
    //     Calcular el número de oraciones usando la función CountSentences

    //     Si no hay palabras
    //         Mostrar mensaje de error y terminar
    //     Fin si

    //     Calcular L y S basado en letras, palabras y oraciones
    //     Usar la fórmula del índice Coleman-Liau para obtener el índice
    //     Redondear el índice al entero más cercano
    //     Determinar y mostrar el nivel de lectura basado en el índice


    public string readability(string? input)
    {
        // Solicitar al usuario que ingrese texto si el texto inicial es nulo o vacío
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Inserte un texto válido:");
            input = Console.ReadLine();
        }

        if (string.IsNullOrEmpty(input))
        {
            return "No se proporcionó texto válido.";
        }

        int letters = CountLetters(input);
        int words = CountWords(input);
        int sentences = CountSentences(input);

        // Verificar que hay palabras para evitar división por cero
        if (words == 0)
        {
            Console.WriteLine("No words found. Cannot compute readability index.");
            return "Error: No words found.";
        }

        // Asegurarse de realizar la división como flotante para obtener resultados precisos
        double L = (double)letters / words * 100;
        double S = (double)sentences / words * 100;

        double index = 0.0588 * L - 0.296 * S - 15.8;
        int grade = (int)Math.Round(index);

        // Imprimir el nivel de grado basado en el índice calculado
        if (grade < 1)
        {
            Console.WriteLine("Before Grade 1");
        }
        else if (grade >= 16)
        {
            Console.WriteLine("Grade 16+");
        }
        else
        {
            Console.WriteLine($"Grade {grade}");
        }

        return grade.ToString();
    }




    //funcion para contar letras


    public static int CountWords(string? input)
    {
        // Comprobar si el input es nulo o vacío para evitar errores
        if (string.IsNullOrEmpty(input))
            return 0;

        // Definir los delimitadores para separar las palabras
        char[] delimiters = new char[] { ' ', '\r', '\n', '\t', '.', ',', ';', ':', '!', '?' };

        // Dividir el input en base a los delimitadores y contar los elementos no vacíos
        var words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        // Devolver el número de palabras
        return words.Length;
    }


    // Función CountSentences(texto)
    // Definir conteo inicial de oraciones
    // Recorrer cada caracter en el texto
    //     Si el caracter es un final de oración (punto, exclamación, interrogación)
    //         Incrementar conteo de oraciones
    //     Fin si
    // Fin recorrido
    // Devolver conteo de oraciones


    public static int CountSentences(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;  // Si el texto está vacío o es nulo, retorna 0
        }

        int count = 0;

        // Itera sobre cada carácter del texto para buscar delimitadores de oraciones
        for (int i = 0; i < input.Length; i++)
        {
            // Comprueba si el carácter actual es un punto, exclamación o interrogación
            if (input[i] == '.' || input[i] == '!' || input[i] == '?')
            {
                count++;  // Incrementa el contador de oraciones
            }
        }

        return count;  // Devuelve el número total de oraciones
    }


    // Funciones para contar letras, palabras y oraciones


    // Función CountLetters(texto)
    //     Definir conteo inicial de letras
    //     Recorrer cada caracter en el texto
    //         Si el caracter es una letra
    //             Incrementar conteo de letras
    //         Fin si
    //     Fin recorrido
    //     Devolver conteo de letras
    // Fin función


    public static int CountLetters(string? input)
    {
        // Verificar si el input es nulo o vacío
        if (string.IsNullOrEmpty(input))
        {
            return 0;  // Si no hay texto, no hay letras que contar
        }

        int count = 0;  // Inicializar el contador de letras fuera del bucle

        // Iterar sobre cada carácter en la cadena de entrada
        for (int i = 0; i < input.Length; i++)
        {
            // Comprobar si el carácter actual es una letra
            if (char.IsLetter(input[i]))
            {
                count++;  // Incrementar el contador si el carácter es una letra
            }
        }

        return count;  // Retornar el número total de letras encontradas
    }


}
