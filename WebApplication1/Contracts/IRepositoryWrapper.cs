﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Contracts
{
    public interface IRepositoryWrapper
    {
         IMovieRepository Movie { get; }
    }
}
