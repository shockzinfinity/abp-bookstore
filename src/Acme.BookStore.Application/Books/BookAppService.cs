using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
  public class BookAppService : CrudAppService<
    Book, // the book entity
    BookDto, // used to show books
    Guid, // primary key of the book entity
    PagedAndSortedResultRequestDto, // used for paging/sorting
    CreateUpdateBookDto>, //used to create/update a book
    IBookAppService
  {
    public BookAppService(IRepository<Book, Guid> repository) : base(repository)
    {
    }
  }
}
