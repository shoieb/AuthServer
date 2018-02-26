using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace AuthServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResource()
        {
            return new List<ApiResource>
            {
                new ApiResource
                {
                    Name = "auth_api",
                    DisplayName = "Auth API",

                    Scopes =
                    {
                        new Scope()
                        {
                            Name = "auth_api",
                            DisplayName = "Auth API"
                        }
                    }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {                
                new Client
                {
                    ClientId = "client",
                    ClientSecrets =
                    {
                        new Secret("client_secret".Sha256())
                    },
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    AllowedScopes =
                    {
                        "auth_api"
                    }
                }
            };
        }
        
    }
}
