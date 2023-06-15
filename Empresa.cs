namespace EspacioEmpresa;

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
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; }
    public char Genero { get; set; }
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargos Cargo { get; set; }

    //Método para calcular la antigüedad del empleado en la empresa
    public int CalcularAntiguedad(){
        TimeSpan tiempoTrabajado = DateTime.Now - FechaIngreso;
        int antiguedad = (int)tiempoTrabajado.TotalDays / 365;
        return antiguedad;
    }

    //Método para calcular la edad del empleado
    public int CalcularEdad(){
        TimeSpan tiempoTranscurrido = DateTime.Now - FechaNacimiento;
        int edad = (int)tiempoTranscurrido.TotalDays / 365;
        return edad;
    }

    //Método para calcular los años restantes para jubilarse
    public int CalcularAniosParaJubilacion(){
        int edadJubilacion = (Genero == 'M') ? 60 : 65;
        int aniosRestantes = edadJubilacion - CalcularEdad();
        return (aniosRestantes > 0) ? aniosRestantes : 0;
    }

    public double CalcularSalario()
    {
        int antiguedad = CalcularAntiguedad();
        double adicional = 0;

        if (antiguedad <= 20){
            adicional = SueldoBasico * (antiguedad * 0.01);
        }else{
            adicional = SueldoBasico * 0.25;
        }
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista){
            adicional *= 1.5;
        }

        if (EstadoCivil == 'C'){
            adicional += 15000;
        }

        double salario = SueldoBasico + adicional;
        return salario;
    }
}
