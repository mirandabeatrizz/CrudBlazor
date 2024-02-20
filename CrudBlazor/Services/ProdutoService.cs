using CrudBlazor.Data;
using CrudBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Produto>> FindAllAsync()
        {
            return await _context.Produto.ToListAsync();
        }

        public async Task<Produto> FindById(int id)
        {
            return await _context.Produto.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddProduto(Produto produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProduto(Produto produto)
        {
            bool hasAny = await _context.Produto.AnyAsync(x => x.Id == produto.Id);
            if (!hasAny)
            {
                throw new Exception("id não encontrado");
            }
            try
            {
                _context.Update(produto);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }

        public async Task DeleteProduto(int produtoId)
        {
            var produto = await _context.Produto.FindAsync(produtoId);
            if(produto != null)
            {
                _context.Remove(produto);
                await _context.SaveChangesAsync(); 
            }
        }
    }
}
