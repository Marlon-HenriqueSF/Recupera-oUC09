using Microsoft.AspNetCore.Server.IIS.Core;
using WebApplication1.Contexts;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        
        private readonly ChapterContext _chapterContext;

      
        public LivroRepository(ChapterContext context)
        {
            _chapterContext = context;
        }

        public List<Livro> Ler()
        {
            return _chapterContext.Livros.ToList();     
        }
    }
}
