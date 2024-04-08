using System;
using Cs50;

Console.WriteLine("Por favor, introduzca la clave para el cifrado (debe tener 26 caracteres únicos):");
string key = Console.ReadLine();
if (!SubstitutionCipher.ValidateKey(key))
{
    Console.WriteLine("La clave no es válida.");
    return; // Salir si la clave no es válida
}

Console.WriteLine("Introduce el texto a cifrar:");
string text = Console.ReadLine();

string encryptedText = SubstitutionCipher.CifrarTexto(text, key);
Console.WriteLine($"Texto cifrado: {encryptedText}");

// Espera para continuar al proceso de descifrado
Console.WriteLine("Presione Enter para continuar al descifrado...");
Console.ReadLine();

Console.WriteLine("Introduce el texto cifrado que desea descifrar:");
string textToDecrypt = Console.ReadLine();

string decryptedText = SubstitutionCipher.DescifrarTexto(key, textToDecrypt);
Console.WriteLine($"Texto descifrado: {decryptedText}");

Console.ReadLine();
