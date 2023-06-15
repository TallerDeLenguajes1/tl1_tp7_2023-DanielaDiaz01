// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EspacioEmpresa;


//PUNTO 2
Empleado[] empleados = new Empleado[3];

//Cargue los datos para 3 empleados
for (int i = 0; i < 3; i++){
    Console.WriteLine("Empleado: ", i+1);
    Empleado empleado = new Empleado();

    Console.WriteLine("Nombre: ");
    empleado.Nombre = Console.ReadLine();

    Console.WriteLine("Apellido: ");
    empleado.Apellido = Console.ReadLine();

    Console.WriteLine("Fecha de nacimiento (dd/mm/aaaa): ");
    empleado.FechaNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

    Console.WriteLine("Estado civil soltero/a(S)/casado/a(C): ");
    empleado.EstadoCivil = Console.ReadLine()[0];

    Console.WriteLine("Genero masculino(M)/femenino(F): ");
    empleado.Genero = Console.ReadLine()[0];

    Console.WriteLine("Sueldo basico: ");
    empleado.SueldoBasico = double.Parse(Console.ReadLine());

    Console.WriteLine("Seleccione cargo: ");
    Console.WriteLine("Auxiliar_0");
    Console.WriteLine("Administrativo_1");
    Console.WriteLine("Ingeniero_2");
    Console.WriteLine("Especialista_3");
    Console.WriteLine("Investigador_4");
    empleado.Cargo = (Cargos)int.Parse(Console.ReadLine());

    empleados[i] = empleado;

    Console.WriteLine();
}

//Monto Total de lo que se paga en concepto de Salarios
double montoTotalSalarios = 0;
foreach (Empleado empleado in empleados){
    double salario = empleado.CalcularSalario();
    montoTotalSalarios += salario;
}

Console.WriteLine("Monto Total de Salarios: $" + montoTotalSalarios);
Console.WriteLine();

//Empleado más próximo a jubilarse
Empleado empleadoJubilacion = null;
int añosFaltantesJubilacion = int.MaxValue;

foreach (Empleado empleado in empleados){
    int añosFaltantes = empleado.Genero == 'M' ? 65 - empleado.CalcularEdad() : 60 - empleado.CalcularEdad();
    if (añosFaltantes < añosFaltantesJubilacion){
        añosFaltantesJubilacion = añosFaltantes;
        empleadoJubilacion = empleado;
    }
}
Console.WriteLine("Empleado más próximo a jubilarse:");
Console.WriteLine("Nombre: " + empleadoJubilacion.Nombre);
Console.WriteLine("Apellido: " + empleadoJubilacion.Apellido);
Console.WriteLine("Edad: " + empleadoJubilacion.CalcularEdad());
Console.ReadLine();

