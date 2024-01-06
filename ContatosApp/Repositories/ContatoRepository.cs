using Microsoft.EntityFrameworkCore;
using ContatosApp.Models;
using ContatosApp.Data;

namespace ContatosApp.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AppDbContext _context;

        public ContatoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contato>> GetAll()
        {
            return await _context.Contatos.ToListAsync();
        }

        public async Task<Contato> GetById(int id)
        {
            return await _context.Contatos.FindAsync(id);
        }

        public async Task Create(Contato contato)
        {
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Contato contato)
        {
            _context.Entry(contato).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var contato = await GetById(id);
            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();
        }
    }
}
