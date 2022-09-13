using System.Collections.Generic;
using puntodos.Class;
using puntodos.Interface;

/*Se necesita un programa que indique cuántos y cuáles ingredientes tiene el paste, como se llama el pastel y cuánto fue el costo del pastel


ENTIDADES
-Ingrediente: Tiene las propiedades de nombre, cantidad y precio, estas propiedades se ingresan cuando se construye el ingrediente.

-Pastel: Tiene las propiedades de nombre, tamaño y lista de ingredientes. 
Y además las acciones de agregar ingrediente, cantidad de ingredientes, listar ingredientes y calcular costo

METODOS
-Calcular costo: retorna el valor total del pastel a partir del precio de los ingredientes.
-Lista de ingredientes: retorna una cadena de texto de los ingredientes con saltos de línea.
-Cantidad de ingredientes: retorna la cantidad de ingredientes.
-Agregar ingrediente: añade un ingrediente a la lista de ingredientes y no retorna nada


*/

List<Ingrediente> ListaIngredientes = new List<Ingrediente>();


Pastel r = new Pastel("Pastel de Zanahoria",44,ListaIngredientes);
r.agregar(ListaIngredientes,"azucar",6,10000);
r.agregar(ListaIngredientes,"zanahoria",13,14000);
r.agregar(ListaIngredientes,"harina",6,12000);
r.listar(ListaIngredientes);
r.costo(ListaIngredientes);
r.cantidad(ListaIngredientes);



