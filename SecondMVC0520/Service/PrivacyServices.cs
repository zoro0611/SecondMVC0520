using SecondMVC0520.DBModels;
using SecondMVC0520.Repos;

namespace SecondMVC0520.Service
{
    public class PrivacyServices
    {
        private readonly IPrivacyRepository<NewBookInfo> _newbookRepository;

        public PrivacyServices(IPrivacyRepository<NewBookInfo> newbookRepository)
        {
            _newbookRepository = newbookRepository;
        }

        public List<NewBookInfo> GetNewBookInfos()
        {
            return _newbookRepository.GetAll().ToList();
        }
    }
}
