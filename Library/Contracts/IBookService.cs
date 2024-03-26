using Library.Models;

namespace Library.Contracts
{
	public interface IBookService
	{
		Task AddBookAsync(AddBookViewModel model);
		Task AddBookToUserCollectionAsync(string userId, BookViewModel book);
		Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();
		Task<BookViewModel?> GetBookByIdAsync(int id);
		Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId);
		Task<AddBookViewModel> GetNewAddBookModelAsync();
		Task RemoveBookFromUserCollectionAsync(string userId, BookViewModel book);
	}
}
