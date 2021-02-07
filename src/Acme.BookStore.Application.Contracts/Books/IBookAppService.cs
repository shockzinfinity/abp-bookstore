using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
  public interface IBookAppService : ICrudAppService< // Defines CRUD methods
    BookDto, // used to show books
    Guid, // primary key of the book entity
    PagedAndSortedResultRequestDto, // used for paging/sorting
    CreateUpdateBookDto> // used to create/update a book
  {
  }
}
