using AuctionSpotlight.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionSpotlight.API.Repositories;

public class AuctionSpotlightDbContext : DbContext 
{
    public AuctionSpotlightDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}
