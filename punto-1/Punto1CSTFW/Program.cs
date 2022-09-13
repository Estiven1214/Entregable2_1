using Ejercicio1.Class;


FabricaMonoPlaza ferrari= new FabricaMonoPlaza("a","Ferrari");
FabricaMonoPlaza mclaren= new FabricaMonoPlaza("b","Mclaren");
FabricaMonoPlaza redBull= new FabricaMonoPlaza("c","RedBull");
Circuito Circuito=new Circuito(ferrari, mclaren,redBull, "Apolo", 3);
Circuito.agregarMonoPlaza(ferrari);
Circuito.realizarPrueba(Circuito.returnNumVueltas(), ferrari.returnMarca());
Circuito.sacarMonoPlaza();
Circuito.agregarMonoPlaza(mclaren);
Circuito.realizarPrueba(Circuito.returnNumVueltas(), mclaren.returnMarca());
Circuito.sacarMonoPlaza();
Circuito.agregarMonoPlaza(redBull);
Circuito.realizarPrueba(Circuito.returnNumVueltas(), redBull.returnMarca());
Circuito.sacarMonoPlaza();
Circuito.listaResultado();
