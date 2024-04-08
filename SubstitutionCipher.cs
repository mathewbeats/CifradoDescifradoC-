using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cs50;

public class SubstitutionCipher
{


    //Empezando con el ejercicio SubstitutionCypher

    //     Función Main(args)
    //     Si no hay exactamente un argumento de línea de comandos
    //         Imprimir mensaje de error
    //         Retornar 1
    //     Fin Si

    //     clave = args[0]
    //     Si no es válida la clave
    //         Imprimir mensaje de error
    //         Retornar 1
    //     Fin Si

    //     Solicitar al usuario el texto a cifrar
    //     texto_cifrado = CifrarTexto(texto, clave)
    //     Imprimir texto_cifrado
    //     Retornar 0
    // Fin Función

    // Función ValidarClave(clave)
    //     Verificar longitud de 26 caracteres
    //     Asegurar que todos los caracteres son letras únicas
    //     Retornar booleano indicando si la clave es válida
    // Fin Función

    // Función CifrarTexto(texto, clave)
    //     Para cada carácter en texto
    //         Si es letra
    //             Encontrar correspondiente en clave
    //             Preservar mayúscula o minúscula
    //         Si no
    //             Agregar carácter original
    //         Fin Si
    //     Retornar texto cifrado
    // Fin Función


    public static string CifrarTexto(string text, string key)
    {
        // Primero, validar la clave. Si no es válida, detener la ejecución.
        if (!ValidateKey(key))
        {
            Console.WriteLine("La clave proporcionada no es válida para el cifrado.");
            return null;
        }

        var map = new Dictionary<char, char>();
        for (int i = 0; i < 26; i++)  // Suponiendo que la clave ya está validada y es correcta
        {
            map.Add((char)('A' + i), char.ToUpper(key[i]));  // Mapeo para letras mayúsculas
            map.Add((char)('a' + i), char.ToLower(key[i]));  // Mapeo para letras minúsculas
        }

        char[] result = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            if (char.IsLetter(currentChar))
            {
                result[i] = map[currentChar];  // Cifrar usando el mapeo
            }
            else
            {
                result[i] = currentChar;  // Dejar los caracteres no alfabéticos sin cambios
            }
        }

        return new string(result);
    }


    // Completando la Función CifrarTexto


    // Para completar tu función CifrarTexto, necesitas llenar el diccionario map con las correspondencias apropiadas de la clave y 
    // luego usar este mapeo para transformar el texto de entrada. Aquí está el pseudocódigo y una explicación de lo que necesitas hacer:

    // Llenar el Diccionario (map):

    // Para cada letra del alfabeto, asocia la letra con su correspondiente en la clave. Asegúrate de manejar tanto las mayúsculas como las minúsculas.
    // Cifrar el Texto:

    // Itera sobre cada carácter en el texto de entrada.

    // Si el carácter es una letra, reemplázalo usando el diccionario map.

    // Si no es una letra, simplemente añádelo al resultado sin cambios.

    // Conserva la mayúscula o minúscula del carácter original.

    // Devolver el Texto Cifrado:

    // Una vez que todos los caracteres han sido procesados, devuelve el texto cifrado resultante.


    // Explicación del Proceso de Mapeo con un Diccionario


    // El código que has mencionado crea un mapeo de cada letra del alfabeto a un carácter específico en la clave proporcionada.

    //  Este mapeo se usa luego para cifrar el texto, reemplazando cada letra del texto de entrada con el carácter correspondiente del diccionario.

    // Iteración sobre el Alfabeto

    // El bucle for (int i = 0; i < 26; i++) itera 26 veces, correspondiendo a las 26 letras del alfabeto inglés.
    //  La variable i se utiliza para generar cada letra del alfabeto de 'A' a 'Z' y de 'a' a 'z', así como para acceder a los caracteres correspondientes en la clave.



    // for (int i = 0; i < 26; i++)
    // {
    //     map.Add((char)('A' + i), char.ToUpper(key[i]));  // Mapeo para letras mayúsculas
    //     map.Add((char)('a' + i), char.ToLower(key[i]));  // Mapeo para letras minúsculas
    // }

    // (char)('A' + i): Esta expresión genera las letras mayúsculas del alfabeto. 

    //Aquí, 'A' es el carácter Unicode/ASCII para la letra 'A',
    //  que tiene un valor numérico de 65. Al sumar i a este valor, desplazas el carácter hacia adelante en el alfabeto. Por ejemplo, cuando i es 0,
    //   (char)('A' + 0) es 'A'; cuando i es 1, (char)('A' + 1) es 'B', y así sucesivamente hasta 'Z'.



    // (char)('a' + i): Similarmente, 'a' representa la letra minúscula 'a', que tiene un valor de 97 en Unicode/ASCII. Sumar i a este valor genera las letras minúsculas del alfabeto.

    // Mapeo a Caracteres de la Clave


    // char.ToUpper(key[i]) y char.ToLower(key[i]): Estas funciones convierten los caracteres de la clave a mayúsculas o minúsculas respectivamente,
    //  asegurando que el mapeo preserve el caso correcto para cada letra en el texto cifrado. Esto significa que si el texto de entrada utiliza letras mayúsculas,
    //   la letra cifrada correspondiente también será mayúscula, y lo mismo para las minúsculas.


    // Importancia de este Proceso


    // Este enfoque asegura que cada letra del texto se reemplace consistentemente según la clave, manteniendo el caso original de cada letra. 
    // Utilizar un diccionario para este mapeo hace que las operaciones de búsqueda y reemplazo durante el cifrado sean extremadamente rápidas (O(1) en promedio para cada búsqueda).

    // Este método de mapeo es eficiente y elegante, ya que separa claramente la creación del mapeo de su uso, lo que hace que el código sea más fácil de entender y mantener. 
    // Si tienes más preguntas sobre este proceso o cualquier otro aspecto de tu implementación, ¡no dudes en seguir preguntando!




    public static bool ValidateKey(string input)
    {
        if (input.Length != 26)
        {
            Console.WriteLine("La clave debe contener exactamente 26 caracteres.");
            return false;
        }

        HashSet<char> set = new HashSet<char>();

        // Normalización y Comprobación: Cada carácter del input se convierte a minúscula con char.ToLower(word) para manejar la insensibilidad a mayúsculas y minúsculas de la clave.
        // Verificación de Letra: Se verifica si lowerCaseChar es una letra usando char.IsLetter(). Si no es una letra, se imprime un mensaje de error y se termina la función retornando false.
        //  Esto asegura que todos los caracteres en la clave sean alfabéticos.
        // Inserción en HashSet: Luego intentas añadir lowerCaseChar al conjunto set usando set.Add(lowerCaseChar).
        // Si lowerCaseChar ya está en el conjunto, Add retorna false, y tú imprimes un mensaje de error y retornas false desde la función, indicando un error porque la clave tiene caracteres
        // duplicados

        // Si lowerCaseChar no estaba en el conjunto, se añade exitosamente y Add retorna true, lo que permite que el ciclo continúe.

        foreach (char c in input)
        {
            char lowerCaseChar = char.ToLower(c); // Normalizar a minúscula para insensibilidad de mayúsculas

            if (!char.IsLetter(lowerCaseChar)) // Asegurarse de que todos los caracteres sean letras
            {
                Console.WriteLine("La clave debe contener solo letras alfabéticas.");
                return false;
            }

            if (!set.Add(lowerCaseChar)) // Intentar añadir a set, Add retorna false si el elemento ya existe
            {
                Console.WriteLine("La clave no debe contener letras repetidas.");
                return false;
            }
        }

        // Si el conjunto tiene exactamente 26 letras únicas y hemos llegado hasta aquí, entonces la clave es válida
        return true;
    }


   
    //     Función DescifrarTexto(textoCifrado, clave)

    //     Si no es válida la clave
    //         Imprimir mensaje de error
    //         Retornar texto vacío

    //     Crear un diccionario para mapeo inverso
    //     Llenar el diccionario usando la clave para mapear cada letra cifrada a su letra original
    //         Para cada índice de 0 a 25
    //             Agregar al diccionario: carácter correspondiente en clave a letra del alfabeto
    //             Ejemplo: si la clave para 'A' es 'N', entonces mapeo['N'] = 'A'

    //     Inicializar la cadena descifrada como vacía

    //     Para cada carácter c en textoCifrado
    //         Si c es una letra
    //             Buscar el carácter descifrado en el diccionario mapeo inverso
    //             Añadir el carácter descifrado a la cadena descifrada, preservando mayúsculas y minúsculas
    //         Si no
    //             Añadir carácter original a la cadena descifrada
    //         Fin Si

    //     Retornar la cadena descifrada
    // Fin Función


    public static string DescifrarTexto(string key, string textoCifrado)
    {
        if (!ValidateKey(key))
        {
            Console.WriteLine("La clave no es correcta");
            return null;
        }

        var map = new Dictionary<char, char>();
        for (int i = 0; i < 26; i++)
        {
            map[char.ToUpper(key[i])] = (char)('A' + i);
            map[char.ToLower(key[i])] = (char)('a' + i);
        }

        Console.WriteLine("Mapa de descifrado:");
        foreach (var pair in map)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }

        char[] result = new char[textoCifrado.Length];
        for (int i = 0; i < textoCifrado.Length; i++)
        {
            char current = textoCifrado[i];
            if (char.IsLetter(current) && map.ContainsKey(current))
            {
                result[i] = map[current];
            }
            else
            {
                result[i] = current;
            }
        }

        return new string(result);
    }







}
