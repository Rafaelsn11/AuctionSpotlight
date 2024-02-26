using AuctionSpotlight.API.Entities;

namespace AuctionSpotlight.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
