using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class MovieRepository: RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(WebApplication1Context repositoryContext)
            : base(repositoryContext)
        {
        }

    }
}
