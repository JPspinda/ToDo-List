using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using To_Do_List.Context;
using To_Do_List.Models;
using To_Do_List.Repositories.Interfaces;

namespace To_Do_List.Repositories
{
    public class ListaRepositorie : IListaRepositorie
    {
        private readonly AppDbContext _context;

        public ListaRepositorie(AppDbContext context)
        {
            _context = context;
        }

        public void CreateList(Lista novaLista)
        {
            _context.Lista.Add(novaLista);
            _context.SaveChanges();
        }

        public void AddElementosLista(int listaId, ElementoLista novoElemento)
        {
            // 1. Busca a lista específica onde o item será inserido
            var lista = _context.Lista
                .Include(p => p.ElementosLista)
                .FirstOrDefault(p => p.ListaId == listaId); // Eu PRECISO pegar a entidade correta da lista, pois senão estou pegando todas as listas, por isso o first or default

            if (lista != null)
            {
                // 2. Adiciona o novo elemento à propriedade de navegação
                lista.ElementosLista.Add(novoElemento);

                // 3. Persiste a mudança no banco de dados
                _context.SaveChanges();
            }
        }

        public Lista? GetLista(int listId)
        {
            return _context.Lista
                .Include(p => p.ElementosLista)
                .FirstOrDefault(p => p.ListaId == listId);
        }
    }
}
