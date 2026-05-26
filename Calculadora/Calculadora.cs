namespace calculadora;
public class Calculadora
{
    private double dato;
    public Calculadora()
    {
        dato=0;
    }
    
    public void sumar(double termino)
    {
       dato+=termino;
    }
    public void resta(double termino)
    {
       dato-=termino;
    }
    public void multiplicar(double termino)
    {
       dato*=termino;
    }
    public void dividir(double termino)
    {
       dato/=termino;
    }
    public void limpiar()
    {
       dato=0;
    }
    
    public double Dato
    {
        get => dato;
    }






}