namespace CrudBlazor.Data
{
    public class Produto
    {
        public int Id { get; set; }
        public string ?Nome { get; set; }
        public double Price { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public Produto(){}

        public Produto(int id, string nome, double price, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Price = price;
            Categoria = categoria;

        }


    }
}
