using BookLibrary_Api.Db;
using BookLibrary_Api.Db.Entities;
using BookLibrary_Api.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MainController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("GetShelfById")]
        public async Task<IActionResult> GetShelf(int shelfId)
        {
            var shelf = await _context.Shelves.FirstOrDefaultAsync(a => a.Id == shelfId);

            if (shelf == null)
            {
                return NotFound();
            }

            return Ok(shelf);
        }

        [HttpPost]
        [Route("CreateShelf")]
        public async Task<IActionResult> CreateShelf(CreateShelfRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var shelf = new Shelf()
            {
                Name = request.Name
            };

            await _context.Shelves.AddAsync(shelf);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        [Route("RenameShelf")]
        public async Task<IActionResult> RenameShelf(RenameShelfRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var shelf = await _context.Shelves.FirstOrDefaultAsync(a => a.Id == request.Id);
            if (shelf == null)
            {
                return NotFound();
            }

            shelf.Name = request.NewName;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete]
        [Route("DeleteShelfById")]
        public async Task<IActionResult> DeleteShelf(int shelfId)
        {
            if (shelfId == 0)
            {
                return BadRequest();
            }

            var shelf = await _context.Shelves.FirstOrDefaultAsync(a => a.Id == shelfId);
            if (shelf == null)
            {
                return NotFound();
            }

            if (shelf.Books.Count != 0)
            {
                return BadRequest();
            }

            _context.Shelves.Remove(shelf);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        [Route("AddBookToShelf")]
        public async Task<IActionResult> AddToShelf(AddToShelfRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var book = new Book()
            {
                ShelfId = request.ShelfId,
                Title = request.Title,
                ISBN = request.ISBN,
                Description = request.Description
            };

            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        [Route("MoveBookToAnotherShelf")]
        public async Task<IActionResult> MoveBookToAnotherShelf(MoveToShelfRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var book = await _context.Books.FirstOrDefaultAsync(a => a.Id == request.Id);
            if (book == null)
            {
                return BadRequest();
            }

            book.ShelfId = request.NewShelfId;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete]
        [Route("RemoveBookById")]
        public async Task<IActionResult> RemoveBook(RemoveBookRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var book = await _context.Books.FirstOrDefaultAsync(a => a.Id == request.Id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}