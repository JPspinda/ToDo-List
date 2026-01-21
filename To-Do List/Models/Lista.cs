namespace To_Do_List.Models
{
    public class Lista
    {
        public int ListaId { get; set; }
        public string Titulo { get; set; }
        public List<ElementoLista> ElementosLista { get; set; }
    }
}
