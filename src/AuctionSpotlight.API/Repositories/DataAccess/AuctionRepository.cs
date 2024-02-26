using AuctionSpotlight.API.Contracts;
using AuctionSpotlight.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionSpotlight.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly AuctionSpotlightDbContext _dbContext;
    public AuctionRepository(AuctionSpotlightDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        var today = new DateTime(2024, 01, 21);

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
    
}
