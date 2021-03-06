﻿using BookLibrary.aspnetcore.Domain;
using BookLibrary.aspnetcore.Services.Interfaces;

namespace BookLibrary.aspnetcore.Services.Implementations
{
    public class BookService : BaseService<Book>, IBookService
    {
        public BookService(string baseUrl) : base(baseUrl, "api/Books/")
        {
        }

    }
}
