namespace To_Do_List.Models
{
    public class ElementoLista
    {
        public int ElementoListaId { get; set; }
        public int ListaId { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }
    }
}
