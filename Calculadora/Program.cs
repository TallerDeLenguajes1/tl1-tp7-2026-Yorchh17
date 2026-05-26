using calculadora;

Calculadora calc1=new Calculadora();
do
{
    
Console.WriteLine("Ingrese la operacion a realizar: 1-Sumar 2-Restar 3-Multiplicar 4-Dividir 5-Multiplicar");
string ?s =Console.ReadLine();
int i=0;
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
        }
    }
    Console.WriteLine(calc1.Dato);


} while (true);


Console.WriteLine(calc1.Dato);