﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoApp.Models
{
    internal class CoinDB
    {
        public string asset_id { get; set; }

        public string name { get; set; }

        public float price_usd { get; set; }

        public string id_icon { get; set; }

        public string icon_url { get; set; }
    }
}
