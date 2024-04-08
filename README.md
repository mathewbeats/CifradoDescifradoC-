# Cifrado y Descifrado de Texto

Este proyecto es un pequeño programa de consola desarrollado en C# que permite a los usuarios cifrar y descifrar texto utilizando un cifrado de sustitución. La clave de cifrado debe tener 26 caracteres únicos y es insensible a mayúsculas y minúsculas.

## Características

- **Validación de clave**: Asegura que la clave ingresada sea de 26 caracteres y contenga solo letras alfabéticas únicas.
- **Cifrado de texto**: Cifra el texto ingresado por el usuario utilizando la clave proporcionada.
- **Descifrado de texto**: Descifra el texto cifrado de vuelta a su forma original utilizando la misma clave.

## Uso

1. **Clave de cifrado**: Al iniciar el programa, se le pedirá al usuario que introduzca una clave de 26 caracteres alfabéticos únicos. Esta clave se utilizará para el cifrado y el descifrado.
2. **Cifrado**: Después de validar la clave, el programa solicitará al usuario que ingrese el texto a cifrar. El texto cifrado se mostrará en la consola.
3. **Descifrado**: A continuación, el usuario puede optar por descifrar un texto, ingresando el texto cifrado cuando se le solicite. El texto descifrado se mostrará en la consola.

## Ejemplo de uso

```bash
Ingrese la clave de cifrado: QWERTYUIOPASDFGHJKLZXCVBNM
Introduce el texto a cifrar: Hello, World!
Texto cifrado: Itssg, Vgksr!

Introduce el texto cifrado que desea descifrar: Itssg, Vgksr!
Texto descifrado: Hello, World!
