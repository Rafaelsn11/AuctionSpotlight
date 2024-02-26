using AuctionSpotlight.API.Entities;
using AuctionSpotlight.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace AuctionSpotlight.API.Controllers;

public class AuctionController : AuctionSpotlightBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {
        var result = useCase.Execute();

        if (result == null)
            return NoContent();

        return Ok(result);
    }
}
