﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityModel.OidcClient;


namespace MauiAppStockTaking.Services
{
    public class AuthService : IAuthService 
{
        private readonly OidcClientOptions _options; 
public AuthService()
        {
            _options = new OidcClientOptions 
{
                Authority = Constants.AuthorityUri,
ClientId = Constants.ClientId,
Scope = Constants.Scope,
RedirectUri = Constants.RedirectUri,
Browser = new AuthBrowser()
};
        }
        public async Task<bool> LoginAsync()
{
var oidcClient = new OidcClient(_options);
var loginResult = await oidcClient.LoginAsync(new LoginRequest()); 
if (loginResult.IsError) 
{
// TODO: inspect and handle error
return false;
}
return true;
}
}
}
