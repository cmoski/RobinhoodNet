// The MIT License (MIT)
// 
// Copyright (c) 2015 Filip Frącz
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BasicallyMe.RobinhoodNet
{
    public class Position
    {
        public Url<Account> AccountUrl { get; set; }
        public Url<Instrument> InstrumentUrl { get; set; }
        public Url<Position> Url { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public decimal IntradayQuantity { get; set; }
        public decimal AverageBuyPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal SharesHeldForBuys { get; set; }
        public decimal SharesHeldForSells { get; set; }
        public Position()
        {
        }

        internal Position(Newtonsoft.Json.Linq.JToken json) : this()
        {

            AccountUrl = new Url<Account>((string)json["account"]);
            InstrumentUrl = new Url<Instrument>((string)json["instrument"]);
            Url = new Url<Position>((string)json["url"]);

            CreatedAt = (DateTime)json["created_at"];
            UpdatedAt = (DateTime)json["updated_at"];

            IntradayQuantity = (decimal)json["intraday_quantity"];
            AverageBuyPrice = (decimal)json["average_buy_price"];
            Quantity = (decimal)json["quantity"];
            SharesHeldForBuys = (decimal)json["shares_held_for_buys"];
            SharesHeldForSells = (decimal)json["shares_held_for_sells"];
        }
    }
}
