using AuctionSpotlight.API.Entities;

namespace AuctionSpotlight.API.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
