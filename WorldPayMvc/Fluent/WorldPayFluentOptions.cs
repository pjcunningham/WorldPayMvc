using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldPayMvc {
    public class WorldPayFluentOptions : IHtmlString, IWorldPayFluentOptions {
        private readonly WorldPay parent;

        public WorldPayFluentOptions(WorldPay parent) {
            this.parent = parent;
        }

        public IWorldPayFluentOptions Address(string address1, string address2, string address3, string town, string region, string postcode, CountryCode countryCode) {
            return parent.Address(address1, address2, address3, town, region, postcode, countryCode);
        }

        public IWorldPayFluentOptions Phones(string telephone, string fax = null) {
            return parent.Phones(telephone, fax);
        }

        public IWorldPayFluentOptions Email(string value) {
            return parent.Email(value);
        }

        public IWorldPayFluentOptions Name(string name, string description = null) {
            return parent.Name(name, description);
        }


        public IWorldPayFluentOptions Add(string propertyName, string value) {
            return parent.Add(propertyName, value);
        }

        public IWorldPayFluentOptions TestMode(TestModeResult tmResult = TestModeResult.NONE, int value = 100) {
            return parent.TestMode(tmResult, value);
        }

        public override string ToString() {
            return parent.ToString();
        }

        public string ToHtmlString() {
            return ToString();
        }
    }
}
