using BookShare.Domain.Entities;
using BookShare.Infrastructure.Repositories;

namespace BookShare.Services.Service
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepositoy;
        public LivroService(ILivroRepository livroRepositoy)
        {
            _livroRepositoy = livroRepositoy;
        }

        public void CreateLivro(Livro livro)
        {
            _livroRepositoy.CreateLivro(livro);
        }

        public void DeleteLivro(Guid id)
        {
            _livroRepositoy.DeleteLivro(id);
        }

        public List<Livro> GetAllLivros()
        {
            return _livroRepositoy.GetAllLivros();
        }

        public Livro GetLivro(Guid id)
        {
            return _livroRepositoy.GetLivro(id);
        }

        public void UpdateLivro(Livro livro)
        {
            _livroRepositoy.UpdateLivro(livro);
        }
    }
}
