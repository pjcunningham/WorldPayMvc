using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldPayMvc.Models {

    public class WorldPayPaymentModel {

        public string instId { get; set; }
        public string cartId { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string town { get; set; }
        public string region { get; set; }
        public string postcode { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string country { get; set; }

        public string testMode { get; set; }

    }
}
