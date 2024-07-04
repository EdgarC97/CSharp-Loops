// ciclo for (manualmente hay que decirle hasta donde tiene que ir)
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Hola coders, esta es la iteracion numero {i}");
// }

//ciclo foreach (recorrer listas o arrays)
//array
// string [] names = {"PEPE","RONI","JOACO","JUANITO"};

// foreach (string name in names)
// {
//     Console.WriteLine($"Hola, los nombres en la lista son {name}");
// }

//while (para mostrar algo de manera constante eje: menu)

// while (10 > 5) //devuelve true
// {
//     Console.WriteLine($"Hola, coders");
// }

// bool flag = true;

// while (flag) //inicia en true
// {
//     Console.WriteLine($"Keep forward");
//     Console.Write($"Quieres repetir la iteracion ? => ");
//     string? answer = Console.ReadLine();

//     if (answer?.ToLower() == "no")
//     {
//         flag = false;//cambiamos a false
//     }
// }

// do while (para ejecutar al menos una vez, luego verifica la condición)
// int count = 0;
// do
// {
//     Console.WriteLine($"Este es el paso número {count}");
//     count++;
// } while (count < 5);

// -------------------------------------------------------------------- EJERCICIOS -------------------------------------------------------------------------------


// 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.
// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine($"El numero es {i+1}");
// }

// 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números pares desde 1 hasta ese número usando un ciclo for.
// Console.WriteLine();
// Console.Write("Por favor ingresa un numero entero => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < userNumber ; i+=2)
// {
//     Console.WriteLine($"Los numeros pares hasta ese numero son: {i+2}");
// }

// 3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de multiplicar de ese número del 1 al 10 usando un ciclo for.
// Console.WriteLine();
// Console.Write("Por favor ingresa un numero entero => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < 11; i++)
// {
//     Console.WriteLine($"Tu numero {userNumber} * {i} = {i*userNumber}");
// }

// 4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pidele al usuario que adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que adivine correctamente usando un ciclo do-while.
// Console.WriteLine();
// int userNumber;
// int ramdomNumber = new Random().Next(1, 101);


// do
// {
//     Console.Write("Adivina el numero del 1 al 100 => ");
//     userNumber = Convert.ToInt32(Console.ReadLine());

//     if (userNumber < 1 ||  userNumber > 100)
//     {
//         Console.WriteLine("El número debe estar entre 1 y 100");
//         Console.WriteLine();

//     }
//     else if (userNumber > ramdomNumber)
//     {
//         Console.WriteLine($"El numero {userNumber} es demasiado alto, intentalo de nuevo");
//         Console.WriteLine();

//     }
//     else if (userNumber < ramdomNumber)
//     {
//         Console.WriteLine($"El numero {userNumber} es demasiado bajo, intentalo de nuevo");
//         Console.WriteLine();
//     }
//     else
//     {
//         Console.WriteLine($"* ! FELICIDADES ! El {userNumber} es correcto :) *");
//         break;
//     }

// } while (true);
// Console.WriteLine("Fin del juego");

// 5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números impares desde ese número hasta 1 usando un ciclo while.
//ORDEN ASCENDENTE
// Console.WriteLine();
// int i = 1;
// Console.Write("Por favor ingresa un numero entero => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// while (i <= userNumber)
// {
//     if(i % 2 != 0)
//     {
//     Console.WriteLine($"Los numeros inpares desde ese numero son: {i}");
//     }
//     i++;
// }
// ORDEN DESCENDENTE 
// Console.WriteLine();
// Console.Write("Por favor ingresa un numero entero => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// int i = userNumber;

// while (i >= 1)
// {
//     if(i % 2 != 0)
//     {
//     Console.WriteLine($"Los numeros inpares desde ese numero son: {i}");
//     }
//     i--;
// }

// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta usando un ciclo while.
// Console.WriteLine();
// string password = "secreta";

// while (true)
// {
//     Console.Write("Por favor ingresa contraseña => ");
//     string? userPassword = Console.ReadLine();

//     if(userPassword?.ToLower() != password)
//     {
//     Console.WriteLine($"Contraseña incorrecta, sigue intentando...");
//     Console.WriteLine();
//     }
//     else
//     {
//     Console.WriteLine($"FELICIDADES ADIVINASTE LA CONTRASEÑA");
//     Console.WriteLine();
//     break;
//     }
// }

// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la secuencia de Fibonacci hasta ese número usando un ciclo for.
// Console.WriteLine();
// int a = 0;
// int b = 1;

// Console.Write("Por favor ingresa un numero entero => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i < userNumber; i++)
// {
//     int temp = a;//guardo a en temp para no perderlo
//     a = b;//a se convierte en b
//     b = temp + a;//sumo a y b

//     Console.WriteLine($"Secuencia de fibonacci de {userNumber} en su iteración {i} ->  es: {temp} ");
// }

// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el número es primo o no usando un ciclo for.
// Console.WriteLine();

// Console.Write("Por favor ingresa un numero entero => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// bool esPrimo = true;

// for (int i = 2; i < userNumber; i++)
// {
//     if (userNumber % i == 0)
//     {
//         esPrimo = false;
//         break;
//     }
// }
// if (esPrimo && userNumber > 1)
// {
//     Console.WriteLine($"El numero {userNumber} es primo");
// }
// else
// {
//     Console.WriteLine($"El numero {userNumber} no es primo");
// }

// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la palabra en una línea separada usando un ciclo foreach.
// Console.WriteLine();
// Console.Write("Por favor ingresa una palabra => ");
// string? userWord = Console.ReadLine();
// Console.WriteLine();


// if (!string.IsNullOrEmpty(userWord))//se verifica si la entrada no es nula o vacia
// {
//     foreach (char i in userWord)
//     {
//         Console.WriteLine($"{i}");
//     }
// }
// else
// {
//     Console.WriteLine("No ingresaste una palabra , Adios...");
// }

// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma de todos los números desde 1 hasta ese número usando un ciclo for.
// Console.WriteLine();
// Console.Write("Por favor ingresa un numero entero positivo ---> ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < userNumber+1; i++)
// {
//     Console.WriteLine($"Tu numero {userNumber} + {i} = {i+userNumber}");
// }