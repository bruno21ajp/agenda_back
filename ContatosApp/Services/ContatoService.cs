using ContatosApp.Models;
using ContatosApp.Repositories;

namespace ContatosApp.Services
{
    public class ContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public async Task<List<Contato>> GetAllContatos()
        {
            return await _contatoRepository.GetAll();
        }

        public async Task<Contato> GetContatoById(int id)
        {
            return await _contatoRepository.GetById(id);
        }

        public async Task CreateContato(Contato contato)
        {
            await _contatoRepository.Create(contato);
        }

        public async Task UpdateContato(Contato contato)
        {
            await _contatoRepository.Update(contato);
        }

        public async Task DeleteContato(int id)
        {
            await _contatoRepository.Delete(id);
        }
    }
}
