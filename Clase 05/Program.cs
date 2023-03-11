void saludo(string nombre)
{

    Console.WriteLine($"Hola {nombre} gusto Saludarte");
}
void desgloce(String nom)
{
    String nuevo=nom.ToUpper();
    String r = "";

    int longitud = nom.Length;
    for (int c =0; c < nuevo.Length; c++)
    {
        Console.SetCursorPosition(10+c, 10);
        Console.Write(nuevo[c] + "");
        r = r + nuevo[c].ToString().ToLower();
        Thread.Sleep(1000); 
    }

    Console.WriteLine("Minuscula=" + r);
    Console.WriteLine(nom[2]);
}
 static int Calculo(int edad)
{ int añoNac = 2023 - edad;
    return añoNac;
}

    string nombre;
    int edad;
int año;
desgloce("Maria");
    Console.WriteLine("Cual es tu nombre");
    nombre = Console.ReadLine();
saludo(nombre);
Console.WriteLine("Cuantos años tienes");
edad = Convert.ToInt32(Console.ReadLine());
año= Calculo(edad);
Console.WriteLine($"Naciste en el año: {año}");
    Console.WriteLine($"Waw{nombre} esa edad de {edad} es genial");

