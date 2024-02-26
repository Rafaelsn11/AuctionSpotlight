using AuctionSpotlight.API.Contracts;
using AuctionSpotlight.API.Entities;

namespace AuctionSpotlight.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly AuctionSpotlightDbContext _dbContext;
    public OfferRepository(AuctionSpotlightDbContext dbContext) => _dbContext = dbContext;
    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
