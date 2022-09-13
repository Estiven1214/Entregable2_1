namespace Ejercicio1.Class;
using Ejercicio1.Interface;

public class Circuito
{
    private string nombre;
    private int nVueltas;
    private bool circuitoDisponible;
    private IMonoPlazaInterface ferrari,mclaren,redBull;
    private Random random;
    private int tiempo;
    private int mejorTiempoF, mejorTiempoM, mejorTiempoR;
    private List<string> resultados;

   

    public Circuito(IMonoPlazaInterface f, IMonoPlazaInterface m,IMonoPlazaInterface r,string n, int v)
    {
        ferrari=f;
        mclaren=m;
        redBull=r;
        nombre=n;
        nVueltas=v;
        circuitoDisponible=true;
        tiempo=0;
        random=new Random();
        mejorTiempoF=999999;
        mejorTiempoM=999999;
        mejorTiempoR=999999;
        resultados=new List<string>();
    }

    public void agregarMonoPlaza(MonoPlaza f)
    {
        if(circuitoDisponible==true)
        {   
           
            circuitoDisponible=false;
           
        }
    }
    public void realizarPrueba(int n, String s)
    {   
        switch (s)
    {
        case "ferrari":
            Console.WriteLine(ferrari.ToString());
            for(int i=0;i<nVueltas;i++ )
            {   ferrari.Apagar();
                ferrari.Encender();
                ferrari.Movimiento();
                ferrari.Detener();
                ferrari.Apagar();
                tiempo=random.Next(111111,999999);
                if(tiempo<mejorTiempoF)
                {
                    mejorTiempoF=tiempo;
                }
                Console.WriteLine("Vuelta # "+(i+1)+" "+tiempo);
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine("Mejor tiempo: "+mejorTiempoF);
            Console.WriteLine("-------------------------------");
            resultados.Add(mejorTiempoF.ToString());
            break;

        case "mclaren":
             Console.WriteLine(mclaren.ToString());
            for(int i=0;i<nVueltas;i++ )
            {   
                mclaren.Apagar();
                mclaren.Encender();
                mclaren.Movimiento();
                mclaren.Detener();
                mclaren.Apagar();
                tiempo=random.Next(111111,999999);
                if(tiempo<mejorTiempoM)
                {
                    mejorTiempoM=tiempo;
                }
                Console.WriteLine("Vuelta # "+(i+1)+" "+tiempo);
                Console.WriteLine("-------------------------------");
                
            }
            Console.WriteLine("Mejor tiempo: "+mejorTiempoM);
            Console.WriteLine("-------------------------------");
            resultados.Add(mejorTiempoM.ToString());
            break;

        case "redbull":
            Console.WriteLine(redBull.ToString());
            for(int i=0;i<nVueltas;i++ )
            {   
                redBull.Apagar();
                redBull.Encender();
                redBull.Movimiento();
                redBull.Detener();
                redBull.Apagar();
                tiempo=random.Next(111111,999999);
                if(tiempo<mejorTiempoR)
                {
                    mejorTiempoR=tiempo;
                }
            Console.WriteLine("Vuelta # "+(i+1)+" "+tiempo);
            Console.WriteLine("-------------------------------");
            }
            Console.WriteLine("Mejor tiempo: "+mejorTiempoR);
            Console.WriteLine("-------------------------------");
            resultados.Add(mejorTiempoR.ToString());
            break;
        default:
            Console.WriteLine($"Measured value is .");
            break;
    }
        
        
    }
    public void sacarMonoPlaza()
    {
        if(circuitoDisponible==false)
        {   
           
            circuitoDisponible=true;
            Console.WriteLine("circuito disponible");
        }
    }
    public int returnNumVueltas(){
        return nVueltas;
    }
    public void  listaResultado()
    {   
        
        Console.WriteLine("Tabla de resultados");
        resultados.Sort();
        
       for(int i=0;i<resultados.Count;i++)
            {
                 Console.WriteLine("Puesto #"+(i+1)+" "+resultados[i]);
            }
    }
}