using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WorldPayMvc {
    public static class WorldPayHelper {

        public static WorldPay WorldPay(this HtmlHelper helper, string installationId, string cartId, string amount, CurrencyCode currency) {

            return new WorldPay(helper, installationId, cartId, amount, currency);
        }
    }
}
