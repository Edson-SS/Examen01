void mostrarMenu()
{
    Console.WriteLine("====================================");
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Numero positivo, cero o negativo");
    Console.WriteLine("2. Dia de Semana");
    Console.WriteLine("3. Suma de 100 numeros naturales");
    Console.WriteLine("4. Imprimir Numeros hasta:");
    Console.WriteLine("5. Calcular area del circulo");
    Console.WriteLine("6. Arreglo predefinido");
    Console.WriteLine("7. Lista de Personas");
    Console.WriteLine("8. Salir");
    Console.WriteLine("Ingresar opcion:");
}

string numeroValor(double valor)
{
    string numeroValor;
    if (valor > 0)
        numeroValor = "Positivo";
    else if (valor < 0)
        numeroValor = "Negativo";
    else
        numeroValor = "Cero";
    return numeroValor;
}

void DiaSemana(double valor)
{
    switch (valor)
    {
        case 1:
            Console.WriteLine("El dia es Lunes");
            break;
        case 2:
            Console.WriteLine("El dia es Martes");
            break;
        case 3:
            Console.WriteLine("El dia es Miercoles");
            break;
        case 4:
            Console.WriteLine("El dia es Jueves");
            break;
        case 5:
            Console.WriteLine("El dia es Viernes");
            break;
        case 6:
            Console.WriteLine("El dia es Sabado");
            break;
        case 7:
            Console.WriteLine("El dia es Domingo");
            break;
        case > 8:
            Console.WriteLine("Error! Intente otro numero");
            break;
        case < 0:
            Console.WriteLine("Error! Intente otro numero");
            break;
    }
}

double sumaNaturales()
{
    double suma = 0;
    for (int i = 1; i <= 100; i++)
    {
        suma = (suma + i);
    }
    return suma;
}

void imprimirNumeros(double Limite)
{
    Console.WriteLine("Inicio:");
    for (int i = 1; i <= Limite; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Fin....");
}

double areaCirculo()
{
    Console.WriteLine("Ingresa el radio:");
    double radio = Convert.ToDouble(Console.ReadLine());
    return Math.Round(Math.Pow(radio, 2) * Math.PI, 2);
}

int[] arreglo = { 0, 10, 20, 30 };

void mostrarArreglo(int[] arreglo)
{
    Console.WriteLine("Arreglo de numeros");
    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.WriteLine(arreglo[i]);
    }
}

List<string> personas = new List<string>();
personas.Add("Edson");
personas.Add("Juan");
personas.Add("Jennifer");
personas.Add("Juan");

void mostrarLista(List<string> personas)
{
    Console.WriteLine("Lista Personas");
    foreach (string item in personas)
    {
        Console.WriteLine(item);
    }
}
//Main
int opcion = 0;
string numeroTipo;
double AreaCirculo = 0;

do
{
    mostrarMenu();
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingresa el numero a evaluar:");
            numeroTipo = numeroValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"El numero es: {numeroTipo}");
            break;
        case 2:
            Console.WriteLine("Ingresa el numero a consultar");
            DiaSemana(Convert.ToDouble(Console.ReadLine()));
            break;
        case 3:
            Console.WriteLine($"La suma de los 100 primeros numeros naturales es: {sumaNaturales()}");
            break;
        case 4:
            Console.WriteLine("Ingresa el numero");
            imprimirNumeros(Convert.ToDouble(Console.ReadLine()));
            break;
        case 5:
            AreaCirculo = areaCirculo();
            Console.WriteLine($"El area del circulo es: {AreaCirculo}");
            break;
        case 6:
            mostrarArreglo(arreglo);
            break;
        case 7:
            mostrarLista(personas);
            break;
    }
} while (opcion != 8);
