using CrudBlazor.Models;

namespace CrudBlazor.Services
{
    public interface ICategoriaService
    {
        Task AddCategoria(Categoria categoria);
        Task Delete(int categoryId);
        Task UpdateCategoria(Categoria categoria);
        Task<List<Categoria>> FindAllAsync();

    }
}
