using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldPayMvc.Models {

    public class WorldPayResponseModel : WorldPayPaymentModel {

        public WorldPayResponseModel() {
            CustomProperties = new Dictionary<string, string>();
        }

        public string delvName { get; set; }
        public string delvAddress1 { get; set; }
        public string delvAddress2 { get; set; }
        public string delvAddress3 { get; set; }
        public string delvTown { get; set; }
        public string delvRegion { get; set; }
        public string delvPostcode { get; set; }
        public string delvCountry { get; set; }
        public string delvCountryString { get; set; }
        public string compName { get; set; }
        public string transId { get; set; }
        public string transStatus { get; set; }
        public string transTime { get; set; }
        public string authAmount { get; set; }
        public string authCost { get; set; }
        public string authCurrency { get; set; }
        public string authAmountString { get; set; }
        public string rawAuthMessage { get; set; }
        public string rawAuthCode { get; set; }
        public string callbackPW { get; set; }
        public string cardType { get; set; }
        public string countryMatch { get; set; }
        public string AVS { get; set; }
        public string wafMerchMessage { get; set; }
        public string authentication { get; set; }
        public string ipAddress { get; set; }
        public string charenc { get; set; }
        public string futurePayId { get; set; }
        public string futurePayStatusChange { get; set; }

        public Dictionary<string, string> CustomProperties { get; private set;}

    }
}
