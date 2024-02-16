using CrudBlazor.Data;
using CrudBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly AppDbContext _context;

        public CategoriaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task <List<Categoria>> FindAllAsync()
        {
            return await _context.Categoria.ToListAsync();
        }

        public async Task AddCategoria(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int categoryId)
        {
            var categoria = await _context.Categoria.FindAsync(categoryId);
            if (categoria != null)
            {
                _context.Remove(categoria);
                await _context.SaveChangesAsync();
            }
        }


        public async Task UpdateCategoria(Categoria categoria)
        {
            bool hasAny = await _context.Categoria.AnyAsync(x => x.Id == categoria.Id);
            if (!hasAny)
            {
                 throw new Exception("Id não encontrado");
            }
            try
            {
                _context.Update(categoria);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }
    }
}
