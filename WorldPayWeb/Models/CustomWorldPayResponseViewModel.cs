using System;
using System.Collections.Generic;
using System.Linq;
using WorldPayMvc.Models;

namespace WorldPayWeb.Models {
    public class CustomWorldPayResponseViewModel : WorldPayResponseModel {
        public Guid MC_SHOPPINGCARTID { get; set; }
        public Guid MC_CUSTOMERID { get; set; }
        public string MC_CUSTOMERREFERENCE { get; set; }
    }
}