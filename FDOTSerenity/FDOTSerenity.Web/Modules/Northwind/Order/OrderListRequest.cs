﻿using Serenity.Services;

namespace FDOTSerenity.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}