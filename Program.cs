
bool Opc = true;

int aceptar = 0;
int rechazar = 0;
int empate= 0;
do
{
    bool salir = true;

    int a = 0 ;
        int r = 0 ;
        int n = 0 ;
        int b = 0 ;
    Console.WriteLine("wenas, digite el nombre de la universidad:");
    string nombreUni = Console.ReadLine();
    do
    {
        
        Console.WriteLine("ingrese el voto: aceptar (A), rechazar (R), nulo (N), blanco (B) o salir (X)");
        string rta = Console.ReadLine().ToLower();
        switch (rta)
        {
            case "a":
                a += 1;
                break;
            case "r":
                r += 1;
                break;
            case "n":
                n += 1;
                break;
            case "b":
                b += 1;
                break;
            case "x":
                salir = false;
                break;
            default:
                break;
        }
        
        rta = "";

    } while (salir == true);
    if (a> r &&a> n &&a> b)
    {
        aceptar += 1;
    }
    if (r> a && r> n && r> b)
    {
        rechazar += 1;
    }
    if (a == r)
    {
        empate += 1;
    }
    Console.WriteLine(nombreUni+ ":" + a+ " aceptan, "+ r + " rechazan, "+ b + " blancos, "+r+" nulos.");
    int total = aceptar + rechazar + empate;
    Console.WriteLine("\ndesea agregar otra universidad ? si (S), no (N)");
    string rtaSalir = Console.ReadLine().ToLower();
    if (rtaSalir == "n")
    {
        Opc = false;
        Console.WriteLine("Universidades totales:"+ total);
        Console.WriteLine("Universidades que aceptan:"+ aceptar);
        Console.WriteLine("Universidades que rechazan:"+ rechazar);
        Console.WriteLine("Universidades que empatan:"+ empate);
    }
} while (Opc == true);