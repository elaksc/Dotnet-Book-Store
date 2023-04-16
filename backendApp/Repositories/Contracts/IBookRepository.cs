﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository : IEntityRepository<Book>
    {
        List<Book> GetLastestBook(int n); // n tane döneceğiz!
        List<Book> GetAllBooksWithDetails();
        Book GetOneBookWithDetails(int id);
    }
}
