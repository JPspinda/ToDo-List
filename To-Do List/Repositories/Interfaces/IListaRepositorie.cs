using To_Do_List.Models;

namespace To_Do_List.Repositories.Interfaces
{
    public interface IListaRepositorie
    {
        void CreateList(Lista novaLista);
        void AddElementosLista(int listaId, ElementoLista novoElemento);
        Lista GetLista(int listId);
    }
}
