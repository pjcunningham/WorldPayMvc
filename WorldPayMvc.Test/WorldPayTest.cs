using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WorldPayMvc;

namespace WorldPayMvc.Test {
    [TestClass]
    public class WorldPayTest {

        private enum WPF {
            InstallationId,
            CartId,
            Amount,
            Currency,
            Email,
            Telephone,
            Fax,
            Address1,
            Address2,
            Address3,
            Town,
            Region,
            PostCode,
            Country,
            Name,
            Description,
        };

        private const string InstallationId = "<input name=\"instId\" type=\"hidden\" value=\"installation\" />";
        private const string CartId = "<input name=\"cartId\" type=\"hidden\" value=\"cart\" />";
        private const string Amount = "<input name=\"amount\" type=\"hidden\" value=\"amount\" />";
        private const string Currency = "<input name=\"currency\" type=\"hidden\" value=\"GBP\" />";
        private const string Email = "<input name=\"email\" type=\"hidden\" value=\"email\" />";
        private const string Telephone = "<input name=\"tel\" type=\"hidden\" value=\"telephone\" />";
        private const string Fax = "<input name=\"fax\" type=\"hidden\" value=\"fax\" />";
        private const string Address1 = "<input name=\"address1\" type=\"hidden\" value=\"address1\" />";
        private const string Address2 = "<input name=\"address2\" type=\"hidden\" value=\"address2\" />";
        private const string Address3 = "<input name=\"address3\" type=\"hidden\" value=\"address3\" />";
        private const string Town = "<input name=\"town\" type=\"hidden\" value=\"town\" />";
        private const string Region = "<input name=\"region\" type=\"hidden\" value=\"region\" />";
        private const string PostCode = "<input name=\"postcode\" type=\"hidden\" value=\"postcode\" />";
        private const string Country = "<input name=\"country\" type=\"hidden\" value=\"GB\" />";

        private const string Name  = "<input name=\"name\" type=\"hidden\" value=\"name\" />";
        private const string Description  = "<input name=\"desc\" type=\"hidden\" value=\"description\" />";
        
        //private const string TestModeDefault = "<input name=\"testMode\" type=\"hidden\" value=\"100\" />";
        //private const string TestModeValue = "<input name=\"testMode\" type=\"hidden\" value=\"200\" />";
        //private const string TestModeREFUSED = "<input name=\"testMode\" name=\"REFUSED\" type=\"hidden\" value=\"100\" />";
        //private const string TestModeAUTHORISED = "<input name=\"testMode\" name=\"AUTHORISED\" type=\"hidden\" value=\"100\" />";
        //private const string TestModeERROR = "<input name=\"testMode\" name=\"ERROR\" type=\"hidden\" value=\"100\" />";
        //private const string TestModeCAPTURED = "<input name=\"testMode\" name=\"CAPTURED\" type=\"hidden\" value=\"100\" />";

        //private const string TestModeREFUSEDValue = "<input name=\"testMode\" name=\"REFUSED\" type=\"hidden\" value=\"200\" />";
        //private const string TestModeAUTHORISEDValue = "<input name=\"testMode\" name=\"AUTHORISED\" type=\"hidden\" value=\"200\" />";
        //private const string TestModeERRORValue = "<input name=\"testMode\" name=\"ERROR\" type=\"hidden\" value=\"200\" />";
        //private const string TestModeCAPTUREDValue = "<input name=\"testMode\" name=\"CAPTURED\" type=\"hidden\" value=\"200\" />";

        private string BuildHtml(params WPF[] args) {

            var result = string.Empty;

            FieldInfo[] fields = this.GetType().GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var arg in args.OrderBy(q => q.ToString())) {
                var field =  fields.SingleOrDefault(q => q.Name == arg.ToString());
                if (field != null) {
                    result += field.GetValue(this).ToString();
                }
            }

            return result;

        }


        [TestMethod]
        public void ShouldCreateRequiredWorldPayHiddenTags() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentEmail() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Email("email").ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency, WPF.Email), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTelephone() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Phones("telephone").ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency, WPF.Telephone), result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentPostCode() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Address("address1", "address2", "address3", "town", "region", "postcode", CountryCode.GB).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency, WPF.Address1, WPF.Address2, WPF.Address3, WPF.Town, WPF.Region, WPF.PostCode, WPF.Country), result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentFax() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Phones("telephone", "fax").ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency, WPF.Telephone, WPF.Fax), result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentName() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Name("name").ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency, WPF.Name), result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentDescription() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Name("name", "description").ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency, WPF.Name, WPF.Description), result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentTestModeDefault() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode().ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.NONE, 200).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeREFUSED() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.REFUSED).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeAUTHORISED() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.AUTHORISED).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeCAPTURED() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.CAPTURED).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeERROR() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.ERROR).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeREFUSEDValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.REFUSED, 200).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeAUTHORISEDValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.AUTHORISED, 200).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeCAPTUREDValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.CAPTURED, 200).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeERRORValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.ERROR, 200).ToHtmlString();

            //assert
            Assert.AreEqual(BuildHtml(WPF.InstallationId, WPF.CartId, WPF.Amount, WPF.Currency), result, ignoreCase: true);

        }
    }
}
