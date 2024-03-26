using Library.Models;

namespace Library.Contracts
{
	public interface IBookService
	{
		Task AddBookToUserCollectionAsync(string userId, BookViewModel book);
		Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();
		Task<BookViewModel?> GetBookByIdAsync(int id);
		Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId);
	}
}
