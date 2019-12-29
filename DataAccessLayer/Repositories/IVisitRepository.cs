using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public interface IVisitRepository
    {
        Visit CreateVisit(Visit visit);
        bool DeleteVisit(int id);
    }
}