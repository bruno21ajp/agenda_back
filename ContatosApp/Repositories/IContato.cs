using ContatosApp.Models;

namespace ContatosApp.Repositories
{
    public interface IContatoRepository
    {
        Task<List<Contato>> GetAll();
        Task<Contato> GetById(int id);
        Task Create(Contato contato);
        Task Update(Contato contato);
        Task Delete(int id);
    }
}
