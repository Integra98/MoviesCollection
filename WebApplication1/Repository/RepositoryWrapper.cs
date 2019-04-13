using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private WebApplication1Context _repoContext;
        private IMovieRepository _movie;

        public IMovieRepository Movie
        {
            get
            {
                if (_movie == null)
                {
                    _movie = new MovieRepository(_repoContext);
                }

                return _movie;
            }
        }

        public RepositoryWrapper(WebApplication1Context repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
