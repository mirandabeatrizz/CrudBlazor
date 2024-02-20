namespace CrudBlazor.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public Produto() { }

        public Produto(int id, string nome, double preco, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;

        }


    }
}
