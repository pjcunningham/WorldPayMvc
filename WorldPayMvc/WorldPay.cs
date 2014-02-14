using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorldPayMvc {

        public class WorldPay : IHtmlString, IWorldPay, IWorldPayFluentOptions {
            private readonly string fInstallationId;
            private readonly string fCartId;
            private readonly string fAmount;
            private readonly CurrenyCode fCurrency;
            private string fPostCode;
            private string fTelephone;
            private string fEmail;
            private string fFax;
            private string fName;
            private string fDescription;
            private CountryCode? fCountryCode;
            private int? fTestModeValue;
            private TestModeResult fTestModeResult;

            public WorldPay(HtmlHelper html, string installationId, string cartId, string amount, CurrenyCode currency) {
                 this.fInstallationId = installationId;
                 this.fCartId = cartId;
                 this.fAmount = amount;
                 this.fCurrency = currency;
            }

            //Render HTML
            public override string ToString() {
                return Render();
            }

            //Return ToString
            public string ToHtmlString() {
                return ToString();
            }

            public IWorldPayFluentOptions PostCode(string value) {
                this.fPostCode = value.Truncate(12);
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions Email(string value) {
                this.fEmail = value.Truncate(80);
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions Description(string value) {
                this.fDescription = value.Truncate(255);
                return new WorldPayFluentOptions(this);
            }
            

            public IWorldPayFluentOptions Telephone(string value) {
                this.fTelephone = value.Truncate(30);
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions Fax(string value) {
                this.fFax = value.Truncate(30);
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions Name(string value) {
                this.fName = value.Truncate(40);
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions Country(CountryCode code) {
                this.fCountryCode = code;
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions TestMode(TestModeResult tmResult = TestModeResult.NONE, int value = 100) {
                this.fTestModeValue = value;
                this.fTestModeResult = tmResult;
                return new WorldPayFluentOptions(this);
            }


            private string Render() {

                var html = string.Empty;

                html += CreateHtml("instId", fInstallationId);
                html += CreateHtml("cartId", fCartId);
                html += CreateHtml("amount", fAmount);
                html += CreateHtml("currency", fCurrency.ToString());

                if (!string.IsNullOrWhiteSpace(fPostCode)) {
                    html += CreateHtml("postcode", fPostCode);
                }

                if (!string.IsNullOrWhiteSpace(fEmail)) {
                    html += CreateHtml("email", fEmail);
                }

                if (!string.IsNullOrWhiteSpace(fTelephone)) {
                    html += CreateHtml("tel", fTelephone);
                }

                if (!string.IsNullOrWhiteSpace(fFax)) {
                    html += CreateHtml("fax", fFax);
                }

                if (!string.IsNullOrWhiteSpace(fName)) {
                    html += CreateHtml("name", fName);
                }

                if (!string.IsNullOrWhiteSpace(fDescription)) {
                    html += CreateHtml("desc", fDescription);
                }

                if (fCountryCode.HasValue) {
                    html += CreateHtml("country", fCountryCode.ToString());
                }

                if (fTestModeValue.HasValue) {
                    html += CreateHtml("testMode", fTestModeValue.ToString(), (fTestModeResult != TestModeResult.NONE) ? fTestModeResult.ToString() : null);
                }
                
                return html;

            }

            private static string CreateHtml(string id, string value, string name = null) {
                var tag = CreateTag(id, value, name);
                return tag.ToString(TagRenderMode.SelfClosing);
            }

            private static TagBuilder CreateTag(string id, string value, string name = null) {
                var tagbuilder = new TagBuilder("input");
                tagbuilder.Attributes.Add("type", "hidden");
                tagbuilder.Attributes.Add("id", id);
                tagbuilder.Attributes.Add("value", value);
                if (!string.IsNullOrWhiteSpace(name)) {
                    tagbuilder.Attributes.Add("name", name);
                }
                return tagbuilder;

            }
        }
}
