﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;

namespace ContactsWebApi.Services
{
    public interface IAzureTokenService
    {
        Task<AccessToken> AuthenticateUser(UserCredentials userCredentials);
    }
}
