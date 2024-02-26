using AuctionSpotlight.API.Communication.Requests;
using AuctionSpotlight.API.Filters;
using AuctionSpotlight.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace AuctionSpotlight.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : AuctionSpotlightBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId,
        [FromBody] ResquestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
