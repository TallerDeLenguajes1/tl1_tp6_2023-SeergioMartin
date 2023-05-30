# Trabajo Practico 6

### ¿String es un tipo de variable por valor o un tipo por referencia?
* Los tipos de datos llamados “por valor” son tipos sencillos que almacenan un dato concreto y que se almacenan en la pila. Por ejemplo, los tipos primitivos de .NET como **int** o **bool**, las estructuras o las enumeraciones. Se almacenan en la pila y se copian por completo cuando se asignan a una función. Por eso cuando se pasa un tipo primitivo a una función, aunque lo cambiemos dentro de ésta, el cambio no se ve reflejado fuera de la misma.

* Los tipos “por referencia” son **todos los demás**, y en concreto todas las **clases de objetos** en .NET, así como algunos tipos primitivos que no tienen un tamaño determinado (como las **cadenas**). Estos tipos de datos se alojan siempre en el montón, por lo que la gestión de la memoria que ocupan es más compleja, y el uso de los datos es menos eficiente (y de menor rendimiento) que con los tipos por valor.

### ¿Qué secuencias de escape tiene el tipo string?
* Secuencia de escape	Representa
* \a	Campana (alerta)
* \b	Retroceso
* \f	Avance de página
* \n	Nueva línea
* \r	Retorno de carro
* \t	Tabulación horizontal
* \v	Tabulación vertical
* \'	Comilla simple
* \"	Comillas dobles
* \\	Barra diagonal inversa
* \?	Signo de interrogación literal
* \ooo	Carácter ASCII en notación octal
* \xhh	Carácter ASCII en notación hexadecimal
* \xhhhh	Carácter Unicode en notación hexadecimal si esta secuencia de escape se utiliza en una constante de caracteres anchos o un literal de cadena Unicode.

Por ejemplo: WCHAR f = L'\x4e00' o WCHAR b[] = L"The Chinese character for one is \x4e00".

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Los caracteres especiales son caracteres contextuales predefinidos que modifican el elemento de programa (una cadena literal, un identificador o un nombre de atributo) para que se antepongan. C# admite los siguientes caracteres especiales:

* @, el carácter de identificador textual.
* $, el carácter de cadena interpolada.

Las cadenas textuales interpoladas comienzan por el carácter $, seguido del carácter @. Los tokens $ y @ se pueden usar en cualquier orden; tanto $@"..." como @$"..." son cadenas textuales interpoladas válidas.

La ventaja de las cadenas textuales es que las secuencias de escape no se procesan, lo que facilita la escritura.