
internal class Program
{
    public static void entrar(char[] array)
    {
        bool igual = false;
        char[] entrar = default;
        do{
        Console.WriteLine("introduzca su contraseña");
        asterisco();
        entrar = Console.ReadLine().ToCharArray();

        if (entrar == array)
        {
            Console.WriteLine("correcto");
            igual = true;
        }

        else
        {
            igual =false;
            Console.WriteLine("error, pruebe otra vez");
        }
        }while (igual != true);
    }

    public static char[] RecogeContraseña()
    {
        int trampa = default;
        char[] contraseña =default;
        do
        {
        Console.WriteLine("registrarse:");
        Console.WriteLine();
        Console.Write("    contraseña:");
        asterisco();
        contraseña = Console.ReadLine().ToCharArray();
        Console.Write("    comprobar contraseña:");
        asterisco();
        char[] comprobar = Console.ReadLine().ToCharArray();

        if(contraseña==comprobar)
        {
            trampa=1;
        }

        else
        {
            trampa =0;
            Console.WriteLine("contraseña no es valida");
        }

        }while(trampa!=1);

        Console.WriteLine("contraseña aceptada");
        return contraseña;
    }

    public static void asterisco()
    {
        ConsoleKeyInfo teclaFisica;
        do
        {
        teclaFisica = Console.ReadKey(true);
        if (teclaFisica.Key != ConsoleKey.Enter)
        {
            Console.Write("*");
            char caracter = teclaFisica.KeyChar;
        }
        } while (teclaFisica.Key != ConsoleKey.Enter);
     }
    
    public static void RellenaArray(int[] array)
    {
        Random r = new Random();
        for (int i=0;i<array.Length;i++)
          array[i] = r.Next(0,101);
    }
    public static void VisualizaElementoMayor(int[] array)
    {
        int numeroMayor=default;
        int posicion =default;
        int num = default;
        int l= default;

        for (int i=0;i<array.Length;i++)
        {
            if (array[i]>numeroMayor)
            {
                numeroMayor=array[i];
            }
        }
        while(num!=numeroMayor)
        {
            num=array[l];
            l=l+1;
            posicion = posicion+1;
        }
        
        Console.WriteLine("el mayor numero es el: " + numeroMayor);
        Console.WriteLine("la posicion es: "+ posicion);
    }


    private static void Main(string[] args)
    {
        //Ejercicio 6 Crea un array de 10 elementos, visualiza el elemento mayor de la serie y la posición que ocupa. Si hay varios iguales, sólo el primero.

        int[] ejemplo = new int [10];
           
        RellenaArray(ejemplo);
            foreach(int c in ejemplo)
        Console.Write(c + " ");
        Console.WriteLine();

        VisualizaElementoMayor(ejemplo);

        //Ejercicio 8 Implementa un programa en C#, que dado un número entero sin signo introducido por teclado, me diga si es capicúa. 
        bool capicua = true ;
       
        Console.WriteLine("dame un numero");
        char[] numero = Console.ReadLine().ToCharArray();

        char[] numeroReves =new char[numero.Length];

        for(int k =0;k<numero.Length;k++){
            numeroReves[k]=numero[k];
        }
        Array.Reverse(numeroReves,0,numero.Length);
            
        for(int j =0;j<numero.Length;j++){
            if (numero[j]!=numeroReves[j])
            {
                j=numero.Length;
                capicua = false;
            }
        }

        if (capicua)
        Console.WriteLine("es capicua");
        else 
        Console.WriteLine("NO es capicua");
        //Ejercicio 9 Crea un menú con tres opciones:
/*
        1. Registrarse en el sistema.
        2. Entrar al sistema.
        3. Salir del programa.*/
        

        int eleccion = default;
        bool Salir = false;
        char[] contraseña = default;
        
        do{
            Console.Write(" 1. Registrarse en el sistema.\n 2. Entrar al sistema. \n 3. Salir del programa.");
            Console.WriteLine();
            eleccion=int.Parse(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                contraseña=RecogeContraseña();
                break;

                case 2:
                entrar(contraseña);
                break;

                case 3:
                Salir = true;
                Console.WriteLine("adios");
                break;
            }
        }while (Salir!=true);

        /*Ejercicio 10 Introduce por teclado una secuencia de calificaciones de los alumnos de un instituto (números enteros entre cero y diez).

        La secuencia termina con la introducción de un número menor que cero o mayor que diez.
        Se supone que como máximo podemos tener 25 alumnos.
        Se trata de obtener la frecuencia de las notas (número de veces que cada nota aparece).*/

        char[] notas = new char [25];
        int [] frecuencia = new int[11];
        int notas_alumnos = default;
        
        string ayuda = "";
  
        while(notas_alumnos<10 && notas_alumnos>0)
        {
            Console.WriteLine("introduzca las notas");
            notas_alumnos = int.Parse(Console.ReadLine());
            ayuda=ayuda+notas_alumnos.ToString();
        }

        for(int j=0;j<ayuda.Length;j++)
        {
            notas[j]=ayuda[j];
        }

        for (int i =0;i<notas.Length;i++)
        {
            if(notas[i]==0)
            {
                frecuencia[0]=frecuencia[0]+1;
            }

            if(notas[i]==1)
            {
                frecuencia[1]=frecuencia[1]+1;
            }

            if(notas[i]==2)
            {
                frecuencia[2]=frecuencia[2]+1;
            }

            if(notas[i]==3)
            {
                frecuencia[3]=frecuencia[3]+1;
            }

            if(notas[i]==4)
            {
                frecuencia[4]=frecuencia[4]+1;
            }

            if(notas[i]==5)
            {
                frecuencia[5]=frecuencia[5]+1;
            }

            if(notas[i]==6)
            {
                frecuencia[6]=frecuencia[6]+1;
            }

            if(notas[i]==7)
            {
                frecuencia[7]=frecuencia[7]+1;
            }

            if(notas[i]==8)
            {
                frecuencia[8]=frecuencia[8]+1;
            }

            if(notas[i]==9)
            {
                frecuencia[9]=frecuencia[9]+1;
            }

            if(notas[i]==10)
            {
                frecuencia[10]=frecuencia[10]+1;
            }
        }

       for(int k =0;k<=10;k++)
        {
            Console.WriteLine(k + frecuencia[k]);
        }
    }
}