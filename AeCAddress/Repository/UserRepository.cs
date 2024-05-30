using AeCAddress.Data;

namespace AeCAddress.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public UserModel Create(UserModel user)
        {
            _applicationDbContext.Usuarios.Add(user);
            _applicationDbContext.SaveChanges();

            return user;
        }
    }
}