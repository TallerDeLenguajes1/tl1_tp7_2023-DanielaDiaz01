namespace EspacioCalculadora;

public class Calculadora{
    private double dato;

    public double Resultado{
        get { return dato; }
    }

    public Calculadora(double valorInicial = 0){
        dato = valorInicial;
    }

    public void Sumar(double termino){
        dato += termino;
    }

    public void Restar(double termino){
        dato -= termino;
    }

    public void Multiplicar(double termino){
        dato *= termino;
    }

    public void Dividir(double termino){
        if (termino != 0){
            dato /= termino;
        }else{
           Console.WriteLine("Division por cero no definida");
        }
    }

    public void Limpiar(){
        dato = 0;
    }
}
