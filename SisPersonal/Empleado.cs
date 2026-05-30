using System.Runtime.InteropServices;

namespace empleado;

public enum Cargos 
{ 
    Auxiliar, 
    Administrativo, 
    Ingeniero, 
    Especialista, 
    Investigador 
}

public class Empleado
{
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    private string apellido;
    public string Apellido 
    {
        get => apellido;
        set => apellido = value;
    }

    private DateTime fechanacimiento;
    public DateTime Fechanacimiento 
    {    
         get => fechanacimiento;
         set => fechanacimiento = value;
    }

    private char estadoCivil;
    public char EstadoCivil 
    { 
        get => estadoCivil; 
        set => estadoCivil = value; 
    }

    private DateTime fechaIngreso;
    public DateTime FechaIngreso 
    { 
        get => fechaIngreso; 
        set => fechaIngreso = value; 
    }

    private double sueldoBasico;
    public double SueldoBasico 
    { 
        get => sueldoBasico; 
        set => sueldoBasico = value; 
    }

    
    private Cargos cargo;
    public Cargos Cargo
    {
        get => cargo;
        set => cargo = value;
    }

    public int CalcularAntiguedad()
    {
        int antiguedad= DateTime.Now.Year - FechaIngreso.Year;

        return antiguedad;

    }

    public int CalcularEdad()
    {
        int edad= DateTime.Now.Year - fechanacimiento.Year;

        return edad;
    }

    public int CalcularJubilacion()
    {
        int jubilacion= 65 - CalcularEdad();

        return jubilacion;
    }


   public double CalcularSalario() 
    {
        double adicional = 0;
        int antiguedad = CalcularAntiguedad(); 
       
        if (antiguedad > 20)
        {
            adicional = sueldoBasico * 0.25;
        }
        else
        {
            adicional = (sueldoBasico * 0.01) * antiguedad;
        }

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional = adicional + (adicional * 0.5);
        }

        if (EstadoCivil == 'C' || EstadoCivil == 'c') 
        {
           
            adicional = adicional + 150000;
        }

        double salario = sueldoBasico + adicional;

        return salario;
    }


}


