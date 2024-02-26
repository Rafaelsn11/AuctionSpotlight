﻿using AuctionSpotlight.API.Entities;

namespace AuctionSpotlight.API.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
