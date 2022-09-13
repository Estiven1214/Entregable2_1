namespace puntodos.Interface;
using puntodos.Class;
using System.Collections.Generic;

public interface IPastel{
    
    public void listar(List<Ingrediente> ListaIngredientes);
    public void cantidad(List<Ingrediente> ListaIngredientes);
    public void agregar(List<Ingrediente> ListaIngredientes, string nombrei, int cantidadi, int precioi);
    public void costo(List<Ingrediente> ListaIngredientes);
}