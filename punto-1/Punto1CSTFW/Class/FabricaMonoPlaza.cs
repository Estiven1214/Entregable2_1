namespace Ejercicio1.Class;
using Ejercicio1.Interface;

public class FabricaMonoPlaza:MonoPlaza,IMonoPlazaInterface
{
    public FabricaMonoPlaza(string escuderia,string marca):base(escuderia, marca)
    {
        
    }
}