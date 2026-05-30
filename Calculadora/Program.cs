using calculadora;

Calculadora calc1 = new Calculadora();
int bandera = 0; 

do
{
    
    Console.WriteLine("Ingrese la operacion a realizar: 1-Sumar 2-Restar 3-Multiplicar 4-Dividir 5-Limpiar 6-PARAR");
    string? s = Console.ReadLine();
    int i = 0;
    
    if (int.TryParse(s, out i))
    {
        switch (i)
        {
            case 1:
                calc1.sumar(5);
                break;
            case 2:
                calc1.resta(2);
                break;
            case 3:
                calc1.multiplicar(3);
                break;
            case 4:
                calc1.dividir(2);
                break;
            case 5:
                calc1.limpiar();
                break;
            case 6:
                bandera = 1; 
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    
    
    Console.WriteLine("Valor actual: " + calc1.Dato);

} while (bandera != 1); 

Console.WriteLine("Programa finalizado. Valor final: " + calc1.Dato);