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

        public IWorldPayFluentOptions PostCode(string value) {
            return parent.PostCode(value);
        }

        public IWorldPayFluentOptions Telephone(string value) {
            return parent.Telephone(value);
        }

        public IWorldPayFluentOptions Email(string value) {
            return parent.Email(value);
        }

        public IWorldPayFluentOptions Fax(string value) {
            return parent.Fax(value);
        }

        public IWorldPayFluentOptions Name(string value) {
            return parent.Name(value);
        }

        public IWorldPayFluentOptions Description(string value) {
            return parent.Description(value);
        }

        public IWorldPayFluentOptions Country(CountryCode value) {
            return parent.Country(value);
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
