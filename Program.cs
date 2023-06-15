// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EspacioCalculadora;


//PUNTO 1
internal class Program
{
    private static void Main(string[] args)
    {
        //Sin interfaz
        //Calculadora calculadora = new Calculadora(10);
        //calculadora.Sumar(5);
        //calculadora.Multiplicar(2);
        //double resultado = calculadora.Resultado;
        //Console.WriteLine("El resultado es: " + resultado); //Salida: 30
        
        Console.WriteLine("\nCALCULADORA");
        Console.WriteLine("\nSeleccione una opcion:");

        int control=1;
        while(control != 0){
            Console.WriteLine("\n1_sumar 2_restar 3_multiplicar 4_dividir 5_limpiar 0_salir");
            int.TryParse(Console.ReadLine(), out int operacion);

            Console.WriteLine("Ingrese valor1:");
            float.TryParse(Console.ReadLine(), out float a);
            Console.WriteLine("Ingrese valor2:");
            float.TryParse(Console.ReadLine(), out float b);

            Calculadora calculadora = new Calculadora(a);

            //float resultado=0;
            switch(operacion){
                case 1: 
                    calculadora.Sumar(b); 
                    break;

                case 2: 
                    calculadora.Restar(b);
                    break;

                case 3: 
                    calculadora.Multiplicar(b);
                    break;

                case 4: 
                    calculadora.Dividir(b);
                    break;
                
                case 5:
                    calculadora.Limpiar();
                    break;

                default:
                    Console.WriteLine("Operacion invalida, elija otra operacion");
                    continue;
            }

            double resultado = calculadora.Resultado;
            Console.WriteLine("Resultado: " + resultado);

            Console.WriteLine("Desea Realizar otra operacion? 1_Si Enter_No");
            if(!int.TryParse(Console.ReadLine(), out int opcion)){
                control = 0;
            }
        }
        Console.WriteLine("¡Gracias por usar la calculadora!");
    }
}
