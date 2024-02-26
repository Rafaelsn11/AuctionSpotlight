using AuctionSpotlight.API.Contracts;
using AuctionSpotlight.API.Entities;

namespace AuctionSpotlight.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly AuctionSpotlightDbContext _dbContext;
    public UserRepository(AuctionSpotlightDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));

}
