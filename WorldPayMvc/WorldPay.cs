using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WorldPayMvc.Models;

namespace WorldPayMvc {

        public class WorldPay : IHtmlString, IWorldPay, IWorldPayFluentOptions {
            private readonly Dictionary<string, string> fCustomProperties = new Dictionary<string, string>();
            private readonly WorldPayPaymentModel fWorldPayPaymentModel = new WorldPayPaymentModel();
            private TestModeResult fTestModeResult;

            public WorldPay(HtmlHelper html, string installationId, string cartId, string amount, CurrenyCode currency) {
                 fWorldPayPaymentModel.instId = installationId;
                 fWorldPayPaymentModel.cartId = cartId;
                 fWorldPayPaymentModel.amount = amount;
                 fWorldPayPaymentModel.currency = currency.ToString();
            }

            public WorldPay(HtmlHelper html, WorldPayPaymentModel worldPayPaymentModel) {
                fWorldPayPaymentModel = worldPayPaymentModel;
            }

            //Render HTML
            public override string ToString() {
                return Render();
            }

            //Return ToString
            public string ToHtmlString() {
                return ToString();
            }

            public IWorldPayFluentOptions Address(string address1, string address2, string address3, string town, string region, string postcode, CountryCode code) {
                fWorldPayPaymentModel.address1 = address1.Truncate(84);
                fWorldPayPaymentModel.address2 = address2.Truncate(84);
                fWorldPayPaymentModel.address3 = address3.Truncate(84);
                fWorldPayPaymentModel.town = town.Truncate(30);
                fWorldPayPaymentModel.region = region.Truncate(30);
                fWorldPayPaymentModel.postcode = postcode.Truncate(12);
                fWorldPayPaymentModel.country = code.ToString();
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions Email(string value) {
                fWorldPayPaymentModel.email = value.Truncate(80);
                return new WorldPayFluentOptions(this);
            }

         
            public IWorldPayFluentOptions Phones(string telephone, string fax = null) {
                fWorldPayPaymentModel.tel = telephone.Truncate(30);
                fWorldPayPaymentModel.fax = fax.Truncate(30);
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions Name(string name, string description = null) {
                fWorldPayPaymentModel.name = name.Truncate(40);
                fWorldPayPaymentModel.desc = description.Truncate(255);
                return new WorldPayFluentOptions(this);
            }


            public IWorldPayFluentOptions Add(string propertyName, string value) {
                fCustomProperties.Add(propertyName, value);
                return new WorldPayFluentOptions(this);
            }

            public IWorldPayFluentOptions TestMode(TestModeResult tmResult = TestModeResult.NONE, int value = 100) {
                fWorldPayPaymentModel.testMode = Convert.ToString(value);
                this.fTestModeResult = tmResult;
                return new WorldPayFluentOptions(this);
            }


            private string Render() {

                var html = string.Empty;

                PropertyInfo[] properties = this.fWorldPayPaymentModel.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var property in properties.OrderBy(q => q.Name)) {
                    var value = property.GetValue(fWorldPayPaymentModel) as string;
                    if (!string.IsNullOrEmpty(value)) {
                        html += CreateHtml(property.Name, value);
                    }
                }

                // Custom Properties
                foreach (var keyvalue in fCustomProperties) {
                    html += CreateHtml(keyvalue.Key, keyvalue.Value);                    
                }
           

                //if (fTestModeValue.HasValue) {
                //    html += CreateHtml("testMode", fTestModeValue.ToString(), (fTestModeResult != TestModeResult.NONE) ? fTestModeResult.ToString() : null);
                //}
                
                return html;

            }

            private static string CreateHtml(string name, string value, string id = null) {
                var tag = CreateTag(name, value, id);
                return tag.ToString(TagRenderMode.SelfClosing);
            }

            private static TagBuilder CreateTag(string name, string value, string id = null) {
                var tagbuilder = new TagBuilder("input");
                tagbuilder.Attributes.Add("type", "hidden");
                tagbuilder.Attributes.Add("name", name);
                tagbuilder.Attributes.Add("value", value);
                if (!string.IsNullOrWhiteSpace(id)) {
                    tagbuilder.Attributes.Add("id", id);
                }
                return tagbuilder;

            }
        }
}
