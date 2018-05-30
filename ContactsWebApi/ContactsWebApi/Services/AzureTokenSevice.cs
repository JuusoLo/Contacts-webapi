using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;

namespace ContactsWebApi.Services
{
    public class AzureTokenSevice : IAzureTokenService
    {
          private readonly AzureSettings _azureSettings;

            public AzureTokenSevice(IOptions<AzureSettings> settings)
            {
                _azureSettings = settings.Value;
            }

            public Task<AccessToken> AuthenticateUser(UserCredentials userCredentials)
        {
            var authenticationParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("client_id", _azureSettings.ApplicationId),
                new KeyValuePair<string, string>("resource", _azureSettings.Resource),
                new KeyValuePair<string, string>("username", userCredentials.Username),
                new KeyValuePair<string, string>("password", userCredentials.Password),
                new KeyValuePair<string, string>("grant_type", _azureSettings.GrantType),
                new KeyValuePair<string, string>("client_secret", _azureSettings.Key)
            };

        }
    }

}
