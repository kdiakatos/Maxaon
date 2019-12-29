using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public interface IUserManagementRepository
    {
        bool CreateUser(User user);
        User Login(User user);
    }
}