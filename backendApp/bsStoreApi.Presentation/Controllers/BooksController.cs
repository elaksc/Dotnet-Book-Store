﻿using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsStoreApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name ="id")] int id)
        {
            var book = _bookService.GetOneBook(id);
            return Ok(book);
        }

        [HttpPost]
        
        public IActionResult CreateOneBook([FromBody] BookDtoForInsertion book)
        {
            _bookService.CreateOneBook(book);
            return Ok(book);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBook([FromRoute(Name ="id")] int id)
        {
            _bookService.DeleteOneBook(id);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute] int id,
            [FromBody] Book book)
        {      
            return Accepted(_bookService.UpdateOneBook(id,book));
        }

        // ./api/books/getlastestbooks?numberOfbooks=15
        [HttpGet("getlastestbooks")]
        public IActionResult GetLastestBooks([FromQuery] int numberOfbooks)
        {
            return Ok(_bookService.GetLastestBook(numberOfbooks));
        }

        // ./api/books/getallbookswithdetails
        [HttpGet("getallbookswithdetails")]
        public IActionResult GetAllBooksWithDetails()
        {
            return Ok(_bookService.GetAllBooksWithDetails());
        }

        [HttpGet("getonebookwithdetails/{id:int}")]
        public IActionResult GetOneBookWithDetails([FromRoute(Name ="id")] int id)
        {
            return Ok(_bookService.GetOneBookWithDetails(id));
        }

    }
}
