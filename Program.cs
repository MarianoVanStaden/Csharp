﻿// See https://aka.ms/new-console-template for more information
#region Ejercicio Nº4 29/04/2023
//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    int primerNumero, segundoNumero;
//    Console.WriteLine("Vamos comparar dos números enteros que usted va a ingresar");
//    Console.WriteLine("Ingrese el primer número (NUM1) entero");
//    primerNumero = int.Parse(Console.ReadLine()); //Con el método Parse el string no puede ser nulo (null), dado a que devuelve un error
//    Console.WriteLine("Ingrese el segundo número (NUM2) entero");
//    segundoNumero = Convert.ToInt32(Console.ReadLine());//Con el método Convert el string si puede ser nulo (null), dado a que cero "0"
//    if (primerNumero == segundoNumero)
//    {
//        Console.WriteLine($"NUM1({primerNumero} es igual a NUM2({segundoNumero})");
//    }
//    else if (primerNumero > segundoNumero) Console.WriteLine($"NUM1({primerNumero}) es mayor a NUM2({segundoNumero})");
//    else
//    {
//        Console.WriteLine($"NUM1({primerNumero}) es menor a NUM2({segundoNumero})");
//    }
//    Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("El dato ingresado tuvo un formato incorrecto, debe ingresar números enteros");

//}

#endregion
#region Ejercicio Nº5 29/04/2023
//using System;
//using System.Linq.Expressions;

//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    int primerNumero, segundoNumero,resultado=0;
//    char inicial;
//    Console.WriteLine("Vamos operar con dos números enteros que usted va a ingresar");
//    Console.WriteLine("Ingrese el primer número (NUM1) entero");
//    primerNumero = int.Parse(Console.ReadLine()); //Con el método Parse el string no puede ser nulo (null), dado a que devuelve un error
//    Console.WriteLine("Ingrese el segundo número (NUM2) entero");
//    segundoNumero = Convert.ToInt32(Console.ReadLine());//Con el método Convert el string si puede ser nulo (null), dado a que cero "0"
//    Console.WriteLine("Ingrese la inicial de la operación que desea realizar. Suma (s), Resta(r), División(d) o Multiplicación(m)");
//    inicial = Convert.ToChar((Console.ReadLine()));
//   switch(inicial)
//    {
//        case 's':
//            resultado = primerNumero + segundoNumero;
//            Console.WriteLine($"La suma de {primerNumero} + {segundoNumero} es: {resultado}");
//            break;
//        case 'r':
//            resultado = primerNumero - segundoNumero;
//            Console.WriteLine($"La resta de {primerNumero} - {segundoNumero} es: {resultado}");
//            break;
//        case 'd':
//            if (segundoNumero == 0) Console.WriteLine("No puede dividir un número por cero (este fue su segundo número ingresado)");
//            else 
//            {resultado = primerNumero / segundoNumero;
//            Console.WriteLine($"La divición de {primerNumero} / {segundoNumero} es: {resultado}");
//            }
//            break;
//        case 'm':
//            resultado = primerNumero * segundoNumero;
//            Console.WriteLine($"La multiplicación de {primerNumero} * {segundoNumero} es: {resultado}");
//            break;
//        default:
//            Console.WriteLine("Usted ingresó un caractér incorrecto");
//            break;
//    }
//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("El dato ingresado tuvo un formato incorrecto, debe ingresar números enteros");

//}

#endregion
#region Ejercicio Nº6 29/04/2023
//using System;
//using System.Linq.Expressions;

//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    double sueldo, asignacion=0;
//    int cantidadHijos = 0;
//    Console.WriteLine("Ingrese su sueldo neto");
//    sueldo = double.Parse(Console.ReadLine());
//    Console.WriteLine("Ingrese cuantos hijos tiene");
//    cantidadHijos = Convert.ToInt16(Console.ReadLine());
//    if (sueldo <= 25000 && cantidadHijos < 4)
//    {
//        asignacion = sueldo * 0.175 * cantidadHijos;
//        Console.WriteLine($"Usted recibirá una asignación de {asignacion}");
//    }
//    else if (sueldo <= 25000 && cantidadHijos > 3 && cantidadHijos <= 7)
//    {
//        asignacion = sueldo * 0.15 * cantidadHijos;
//        Console.WriteLine($"Usted recibirá una asignación de {asignacion}");
//    }
//    if (sueldo > 25000 && sueldo <=50000 && cantidadHijos > 4 && cantidadHijos <= 7)
//    {
//        asignacion = sueldo * 0.095 * cantidadHijos;
//        Console.WriteLine($"Usted recibirá una asignación de {asignacion}");
//    }
//    if (sueldo > 50000 && cantidadHijos > 5 && cantidadHijos <= 7)
//    {
//        asignacion = sueldo * 0.086 * cantidadHijos;
//        Console.WriteLine($"Usted recibirá una asignación de {asignacion}");
//    }
//    else Console.WriteLine("Usted no recibirá ninguna asignación");

//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("Los datos ingresados tuvieron un formato incorrecto");

//}

#endregion
#region Ejercicio Nº7 02/05/2023
//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    double primerLado, segundoLado, tercerLado;
//    Console.WriteLine("¡Bienvenido! vamos a analizar que tipo de triangulo tiene en base a sus lados");
//    Console.WriteLine("Ingrese el primer lado:");
//    primerLado = double.Parse(Console.ReadLine()); //Con el método Parse el string no puede ser nulo (null), dado a que devuelve un error
//    Console.WriteLine("Ingrese el segundo lado:");
//    segundoLado = Convert.ToDouble(Console.ReadLine());//Con el método Convert el string si puede ser nulo (null), dado a que cero "0"
//    Console.WriteLine("Ingrese el tercer lado:");
//    tercerLado = double.Parse(Console.ReadLine()); // Para este caso es mejor usar el Parce dado a que 0 no es una posibilidad para un lado
//    if (primerLado == segundoLado && primerLado == tercerLado) Console.WriteLine("Su triangulo es equilátero");
//    else if ((primerLado == segundoLado && primerLado != tercerLado) || (primerLado == tercerLado && primerLado != segundoLado) || (segundoLado == tercerLado && primerLado != segundoLado))
//    {
//        Console.WriteLine("Su triangulo es isósceles");
//    }
//    else
//    {
//        Console.WriteLine("Su triangulo es escaleno");
//    }
//    Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("El dato ingresado tuvo un formato incorrecto, debe asignar coeficientes");

//}

#endregion
#region Ejercicio Nº8 02/05/2023
//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    double A, B, C, aux, ZZ;
//    Console.WriteLine("Ingrese el valor de A");
//    A = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Ingrese el valor de B");
//    B = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Ingrese el valor de C");
//    C = Convert.ToDouble(Console.ReadLine());
//    aux = 2*Math.Abs(A)-3;
//    if (aux<A%2+5)
//    {
//        ZZ = A;
//        A = B;
//        B = ZZ;
//        aux = Math.Truncate(ZZ / B);
//    }
//    else
//    {
//        ZZ = C;
//        C = A;
//        A = ZZ;
//        if (ZZ<=B)
//        { aux = B;
//            B = C;
//            C= aux;
//        }
//        Console.WriteLine($"El valor de ZZ es:{ZZ}"); //5
//        Console.WriteLine($"El valor de aux es:{aux}"); //11
//        Console.WriteLine($"El valor de A es:{A}, el de B es:{B} y el de C es:{C}"); //5,3,-7
//    }
//    Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("El dato ingresado tuvo un formato incorrecto, debe asignar coeficientes");

//}

#endregion
#region Ejercicio Nº9 A 02/05/2023
//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    double valorX = int.Parse(Console.ReadLine()); //Con el método Parse el string no puede ser nulo (null), dado a que devuelve un error
//    double valorY = 0;
//    Console.WriteLine("Ingrese el valor de X:");
//    if (valorX == 0) Console.WriteLine("El valor de Y=0");
//    else if (valorX <=0 )
//     {
//        valorY= 1+ Math.Pow((1+valorX), 2);
//        Console.WriteLine($"El valor de Y = {valorY}");
//    }
//      else
//    {
//        valorY = 1 - Math.Pow((1 + valorX), 2);
//        Console.WriteLine($"El valor de Y = {valorY}");
//    }
//    Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("El dato ingresado tuvo un formato incorrecto, debe asignar coeficientes");

//}

#endregion
#region Ejercicio Nº9 B 02/05/2023
//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    double primerNumero, segundoNumero;
//    Console.WriteLine("Ingrese el primer número");
//    primerNumero = double.Parse(Console.ReadLine()); //Con el método Parse el string no puede ser nulo (null), dado a que devuelve un error
//    Console.WriteLine("Ingrese el segundo número");
//    segundoNumero = double.Parse(Console.ReadLine()); //Uso Parse porque no quiero que tome el null como 0
//        if (primerNumero < 0 && segundoNumero < 0) Console.WriteLine("Ambos números son negativos");
//        else if (primerNumero > 0 && segundoNumero > 0) Console.WriteLine("Ambos números son positivos");
//        else if (primerNumero == 0 || segundoNumero == 0) Console.WriteLine("Ambos números son igual a cero");
//        else if ((primerNumero < 0 && segundoNumero == 0)||(segundoNumero < 0 && primerNumero == 0)) Console.WriteLine("Un número es negativo y el otro es cero");
//        else if ((primerNumero > 0 && segundoNumero == 0) || (segundoNumero > 0 && primerNumero == 0)) Console.WriteLine("Un número es positivo y el otro es cero");
//        else if (primerNumero < 0 || segundoNumero < 0) Console.WriteLine("Alguno de los números es negativo");

//    Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("El dato ingresado tuvo un formato incorrecto, debe asignar coeficientes");

//}

#endregion
#region Ejercicio Nº9 C 02/05/2023
//using System.Runtime.Intrinsics.X86;

//try //El try catch va a evitar que se rompa el programa cuando ingresen simbolos o letras en lugar de números
//{
//    int numeroLibreta;
//    double nota1, nota2, nota3, promedio=0;
//    Console.WriteLine("¡Hola alumno! Ingrese su número de libreta");
//    numeroLibreta = int.Parse(Console.ReadLine());
//    Console.WriteLine("Alumno, ingrese su primer calificación");
//    nota1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Alumno, ingrese su segunda calificación");
//    nota2 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Alumno, ingrese su tercer calificación");
//    nota3 = int.Parse(Console.ReadLine());
//    promedio= (nota1+nota2+nota3)/3;
//    Console.WriteLine($"Su número de libreta es: {numeroLibreta}");
//    if (promedio >= 9) { 
//        Console.WriteLine("Usted aprobó");
//        Console.WriteLine("Su concepto es: Sobresaliente");
//    }
//    else if (promedio >= 8   && promedio < 9)
//    {
//        Console.WriteLine("Usted aprobó");
//        Console.WriteLine("Su concepto es: Distinguido");
//    }
//    else if (promedio >= 6 && promedio < 8)
//    {
//        Console.WriteLine("Usted aprobó");
//        Console.WriteLine("Su concepto es: Bueno");
//    }
//    else if (promedio >= 4 && promedio < 6)
//    {
//        Console.WriteLine("Usted aprobó");
//        Console.WriteLine("Su concepto es: Regular");
//    }
//    if (promedio < 4)
//    {
//        Console.WriteLine("Usted no aprobó");
//        Console.WriteLine("Su concepto es: Insuficiente");
//    }

//    Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
//}
//catch (FormatException) //el catch atrapa solo errores de formato
//{
//    Console.WriteLine("El dato ingresado tuvo un formato incorrecto, debe asignar coeficientes");

//}

#endregion
#region Ejercicio Nº9 D 02/05/2023
//using System;

//class GuiaNumero2
//{
//    static void Main(string[] args)
//    {
//        try  
//{
//    char primera, segunda, tercera;
//    Console.WriteLine("Ingrese las tres letras:");
//    primera = Console.ReadKey().KeyChar;
//    segunda = Console.ReadKey().KeyChar;
//    tercera = Console.ReadKey().KeyChar;
//    Console.WriteLine();
//    if (primera >= segunda && primera >= tercera && segunda >= tercera) Console.WriteLine($"El orden actual de las letras es {tercera} - {segunda} - {primera}");
//    else if (primera >= segunda && primera >= tercera && tercera >= segunda) Console.WriteLine($"El orden actual de las letras es {segunda} - {tercera} - {primera}");
//    else if (segunda >= tercera && segunda >= tercera && primera >= tercera) Console.WriteLine($"El orden actual de las letras es {tercera} - {primera} - {segunda}");
//    else if (segunda >= tercera && segunda >= primera && tercera >= primera) Console.WriteLine($"El orden actual de las letras es {primera} - {tercera} - {segunda}");
//    else if (tercera >= primera && tercera >= segunda && primera >= segunda) Console.WriteLine($"El orden actual de las letras es {primera} - {tercera} - {tercera}");
//    else
//    Console.WriteLine($"El orden de las letras es {primera} - {tercera} - {segunda}");
//    Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola   
//}
//catch (FormatException)
//{
//    Console.WriteLine("Debe ingresar exactamente tres letras");
//}
//    }
//}
//using System;

//class GuiaNumero2
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            char primera, segunda, tercera, menor, medio, mayor;
//            Console.WriteLine("Ingrese las tres letras:");
//            primera = Console.ReadKey().KeyChar;
//            segunda = Console.ReadKey().KeyChar;
//            tercera = Console.ReadKey().KeyChar;
//            Console.WriteLine();
//            if (primera<=segunda && primera<=tercera)
//            { menor = primera;
//                if (segunda<=tercera)
//                { medio = segunda;
//                    mayor = tercera;
//                }
//                else if (segunda <= primera && segunda <= tercera)
//                {
//                    menor = segunda;
//                    if (primera <= tercera)
//                    {
//                        medio = primera;
//                        mayor = tercera;
//                    }
//                    else
//                    {
//                        menor = tercera;
//                        if (primera <= segunda)
//                        {
//                            medio = primera;
//                            mayor = segunda;
//                        }
//                        else { medio = segunda;
//                            mayor = primera;
//                        }
//                    }

//                 Console.WriteLine($"El orden es {menor}, {medio}, {mayor}");
//                }
//            } 


//            Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola   
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Debe ingresar exactamente tres letras");
//        }
//    }
//}
#endregion
#region Ejercicio Nº9 E 06/05/2023
//using System;
//class GuiaNumero2
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int dia, mes;
//            Console.WriteLine("Ingrese el número del día");
//            dia = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese el número del mes");
//            mes = int.Parse(Console.ReadLine());
//            if ((dia >= 21 && mes == 12) || mes == 1 || mes == 2 || (dia >= 20 && mes == 3)) Console.WriteLine("La estación es Verano");
//            if ((dia >= 21 && mes == 3) || mes == 4 || mes == 5 || (dia >= 20 && mes == 6)) Console.WriteLine("La estación es Otoño");
//            if ((dia >= 21 && mes == 6) || mes == 7 || mes == 8 || (dia >= 20 && mes == 9)) Console.WriteLine("La estación es Invierno");
//            if ((dia >= 21 && mes == 9) || mes == 10 || mes == 11 || (dia >= 20 && mes == 12)) Console.WriteLine("La estación es Primavera");
//            Console.WriteLine("Gracias por probar nuestro programa");

//            Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola   
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Debe ingresar exactamente tres letras");
//        }
//    }
//}
#endregion
#region Ejercicio Nº10 06/05/2023
//using System;
//class GuiaNumero2
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int dia;
//            Console.WriteLine("Ingrese un número entre 1 y 7, y se le devolverá a que día de la semana es hoy");
//            dia = int.Parse(Console.ReadLine());

//            if (dia == 1) Console.WriteLine("hoy es lunes");
//            if (dia == 2) Console.WriteLine("hoy es martes");
//            if (dia == 3) Console.WriteLine("hoy es miercoles");
//            if (dia == 4) Console.WriteLine("hoy es jueves");
//            if (dia == 5) Console.WriteLine("hoy es viernes");
//            if (dia == 6) Console.WriteLine("hoy es sabado");
//            if (dia == 7) Console.WriteLine("hoy es domingo");
//            if (dia > 7) Console.WriteLine("El numero ingresado es incorrecto");
//            Console.WriteLine("Gracias por probar nuestro programa");

//            Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola   
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Debe ingresar exactamente tres letras");
//        }
//    }
//}
#endregion 
#region Ejercicio Nº11 06/05/2023
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            char letra;
//            Console.WriteLine("Ingrese primer letra de su estado civil");
//            letra = Console.ReadKey().KeyChar;
//            letra = Char.ToUpper(letra);
//            Console.WriteLine();
//            switch (letra)
//            {
//                case 'C':
//                    Console.WriteLine("CASADO");
//                    break;

//                case 'S':
//                    Console.WriteLine("SOLTERO");
//                    break;

//                case 'V':
//                    Console.WriteLine("VIUDO");
//                    break;

//                case 'D':
//                    Console.WriteLine("DIVORCIADO");
//                    break;

//                default:
//                    Console.WriteLine("NO EXISTE");
//                    break;
//            }
//            Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
//        }



//        catch (FormatException)
//        {
//            Console.WriteLine("El dato ingresado no es valido");
//        }
//    }
//}
#endregion
#region Ejercicio Nº12 06/05/2023
using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            char ingreso;
            Console.WriteLine("Ingrese un carácter cualquiera");
            ingreso = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (Char.IsDigit(ingreso)) Console.WriteLine("El carácter es un número");
            else if (Char.IsLetter(ingreso))
                {
                if (EsVocal(ingreso)) Console.WriteLine("El carácter es una vocal");
                else Console.WriteLine("El carácter es una consonante");
                }
            else Console.WriteLine("El carácter es del tipo especial");
            Console.ReadKey(); //evita que una vez que se muestren los resultados se cierre la consola
        }



        catch (FormatException)
        {
            Console.WriteLine("El dato ingresado no es valido");
        }
    }

    static bool EsVocal(char ingreso)
    {
        ingreso = Char.ToLower(ingreso);
        return ingreso == 'a' || ingreso == 'e' || ingreso == 'i' || ingreso == 'o' || ingreso == 'u';
    }
}
#endregion