using SecondMVC0520.DBModels;
using SecondMVC0520.Repos;

namespace SecondMVC0520.Service
{
    public class HomeServices
    {
        private readonly IRepository<BookInfo> _bookRepository;

        public HomeServices(IRepository<BookInfo> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<BookInfo> GetBookInfos()
        {
            return _bookRepository.GetAll().ToList();
        }
    }
}
