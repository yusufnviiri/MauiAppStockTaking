﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppStockTaking
{
    public static class Constants
    {
        public const string BaseUrl = "https:/ /8284-159-196-124-207.ngrok.io";
        public const string RedirectUri = "auth.com.mildredsurf.stocktake:/ /callback";
        public const string AuthorityUri = "https:/ /8284-159-196-124-207.ngrok.io";
        public const string ClientId = "com.mildredsurf.stocktake";
        public const string Scope = "openid profile offline_access MauiStockTake.WebUIAPI";

    }
}
