using BookShare.Domain.Entities;

namespace BookShare.Services.Service
{
    public interface ILivroService
    {
        public List<Livro> GetAllLivros();
        public Livro GetLivro(Guid id);
        public void UpdateLivro(Livro livro);
        public void CreateLivro(Livro livro);
        public void DeleteLivro(Guid id);
    }
}
