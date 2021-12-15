namespace Training.Application.Books
{
    interface IBookService
    {
        System.Collections.Generic.IEnumerable<Book> Get();
    }
}