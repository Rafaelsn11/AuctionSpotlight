using AuctionSpotlight.API.Communication.Requests;
using AuctionSpotlight.API.Contracts;
using AuctionSpotlight.API.Entities;
using AuctionSpotlight.API.Services;

namespace AuctionSpotlight.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly ILoggedUser _loggedUser;
    private readonly IOfferRepository _repository;

    public CreateOfferUseCase(ILoggedUser loggedUser, IOfferRepository repository)
    {
        _loggedUser = loggedUser;
        _repository = repository;
    }


    public int Execute(int ItemId, ResquestCreateOfferJson request)
    {
        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = ItemId,
            Price = request.Price,
            UserId = user.Id,
        };

        _repository.Add(offer);

        return offer.Id;
    }
}
