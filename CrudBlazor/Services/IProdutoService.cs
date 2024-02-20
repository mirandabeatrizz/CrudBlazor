using CrudBlazor.Models;

namespace CrudBlazor.Services
{
    public interface IProdutoService
    {
        Task<List<Produto>> FindAllAsync();
        Task<Produto> FindById(int id);
        Task AddProduto(Produto produto);
        Task UpdateProduto(Produto produto);
        Task DeleteProduto(int produtoId);
    }
}
