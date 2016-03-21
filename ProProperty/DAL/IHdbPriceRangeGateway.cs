﻿using ProProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProProperty.DAL
{
    interface IHdbPriceRangeGateway
    {
        List<Hdb_price_range> hdbPriceRangeQuery();
        void DeleteAllHdbPriceRange();
    }
}
