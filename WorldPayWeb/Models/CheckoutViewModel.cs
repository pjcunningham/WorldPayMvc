using System;
using System.Collections.Generic;
using System.Linq;
using WorldPayMvc;
using System.Web;

namespace WorldPayWeb.Models {
    public class CheckoutViewModel {

        // Required Properties
        public string InstallationId { get; set; }
        public string CartId { get; set; }
        public decimal Total { get; set; }
        public CurrencyCode CurrencyCode { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public CountryCode CountryCode { get; set; }
        public string PostCode { get; set; }

    }
}