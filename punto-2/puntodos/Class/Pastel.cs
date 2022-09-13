namespace puntodos.Class;
using System.Collections.Generic;
using puntodos.Interface;

public class Pastel :IPastel{
    public string nombrepast;
    public int tamano;
    public List<Ingrediente> ListaIngredientes;

    
    public Pastel(string nombre,int tam,List<Ingrediente> ListaIngredientes){
        this.nombrepast=nombre;
        this.tamano= tam;
        this.ListaIngredientes= ListaIngredientes;

    }
    

    
    public void costo(List<Ingrediente> ListaIngredientes){
        int total=0;

        for (int i = 0; i < ListaIngredientes.Count; i++)
        {
            total = total+ListaIngredientes[i].precioing;
        }


       Console.WriteLine("Precio del pastel: "+total);

    }

    public void listar(List<Ingrediente> ListaIngredientes){
        Console.WriteLine("-------------");
        Console.WriteLine("INGREDIENTES");
        Console.WriteLine("-------------");
        for (int i = 0; i < ListaIngredientes.Count; i++)
            {
                Console.WriteLine("- "+ListaIngredientes[i].nombreig);
            }

    }

    public void cantidad(List<Ingrediente> ListaIngredientes){
        int cantidadg;
        cantidadg = ListaIngredientes.Count;
        Console.WriteLine("Cantidad de Ingredientes: "+cantidadg);
    }

    public void agregar(List<Ingrediente> ListaIngredientes,string nombrei,int cantidadi, int precioi){
        ListaIngredientes.Add(new Ingrediente(nombrei,cantidadi,precioi));

    }

}