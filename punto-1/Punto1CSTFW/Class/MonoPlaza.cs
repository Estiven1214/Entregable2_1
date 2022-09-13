namespace Ejercicio1.Class;
using Ejercicio1.Interface;

public abstract class MonoPlaza: IMonoPlazaInterface
{
    protected string escuderia;
    protected bool motor;
    protected string marca;
    protected bool estadoMotor;
    protected bool movimientoMonoPlaza;

    public MonoPlaza(string e, string m)
    {   marca=m.ToLower();
        escuderia=e;
        estadoMotor=false;
        movimientoMonoPlaza=false;
       
    }
    public void Encender()
    {
       if(estadoMotor==false)
       {    
            estadoMotor=true;
            Console.WriteLine("La monoplaza esta encendida");
       }
       
    }
    public void Apagar()
    {
        if(estadoMotor==true && movimientoMonoPlaza==false)
        {
            estadoMotor=false;
            Console.WriteLine("La monoplaza esta apagada");
        }else{
           Console.WriteLine("La monoplaza esta apagada"); 
        }
        
       
    }
    public void Detener()
    {
       if(estadoMotor==true && movimientoMonoPlaza==true)
       {    
            movimientoMonoPlaza=false;
            Console.WriteLine("La monoplaza esta detenida");
       }
    }
    public void Movimiento()
    {
        if(estadoMotor==true && movimientoMonoPlaza==false)
        {   
            movimientoMonoPlaza=true;
            Console.WriteLine("La monoplaza esta en movimiento");
        }
    }

    public string returnEcuderia()
    {
        return escuderia;
    }
    public string returnMarca()
    {
        return marca;
    }
    public bool returnMotor()
    {
        return motor;
    }

    public override string ToString()
   {
      return  "Marca: "+marca.ToString()+" Escuderia: "+ escuderia.ToString()+" ";
   }


}