using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using WorldPayMvc;

namespace WorldPayMvc.Test {
    [TestClass]
    public class WorldPayTest {

        private const string Default = "<input id=\"instId\" type=\"hidden\" value=\"installation\" /><input id=\"cartId\" type=\"hidden\" value=\"cart\" /><input id=\"amount\" type=\"hidden\" value=\"amount\" /><input id=\"currency\" type=\"hidden\" value=\"GBP\" />";
        private const string Email = "<input id=\"email\" type=\"hidden\" value=\"email\" />";
        private const string Telephone = "<input id=\"tel\" type=\"hidden\" value=\"telephone\" />";
        private const string PostCode = "<input id=\"postcode\" type=\"hidden\" value=\"postcode\" />";
        private const string Fax  = "<input id=\"fax\" type=\"hidden\" value=\"fax\" />";
        private const string Name  = "<input id=\"name\" type=\"hidden\" value=\"name\" />";
        private const string Description  = "<input id=\"desc\" type=\"hidden\" value=\"description\" />";
        private const string Country  = "<input id=\"country\" type=\"hidden\" value=\"GB\" />";
        private const string TestModeDefault = "<input id=\"testMode\" type=\"hidden\" value=\"100\" />";
        private const string TestModeValue = "<input id=\"testMode\" type=\"hidden\" value=\"200\" />";
        private const string TestModeREFUSED = "<input id=\"testMode\" name=\"REFUSED\" type=\"hidden\" value=\"100\" />";
        private const string TestModeAUTHORISED = "<input id=\"testMode\" name=\"AUTHORISED\" type=\"hidden\" value=\"100\" />";
        private const string TestModeERROR = "<input id=\"testMode\" name=\"ERROR\" type=\"hidden\" value=\"100\" />";
        private const string TestModeCAPTURED = "<input id=\"testMode\" name=\"CAPTURED\" type=\"hidden\" value=\"100\" />";

        private const string TestModeREFUSEDValue = "<input id=\"testMode\" name=\"REFUSED\" type=\"hidden\" value=\"200\" />";
        private const string TestModeAUTHORISEDValue = "<input id=\"testMode\" name=\"AUTHORISED\" type=\"hidden\" value=\"200\" />";
        private const string TestModeERRORValue = "<input id=\"testMode\" name=\"ERROR\" type=\"hidden\" value=\"200\" />";
        private const string TestModeCAPTUREDValue = "<input id=\"testMode\" name=\"CAPTURED\" type=\"hidden\" value=\"200\" />";


        [TestMethod]
        public void ShouldCreateRequiredWorldPayHiddenTags() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).ToHtmlString();

            //assert
            Assert.AreEqual(Default, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentEmail() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Email("email").ToHtmlString();

            //assert
            Assert.AreEqual(Default+Email, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTelephone() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Telephone("telephone").ToHtmlString();

            //assert
            Assert.AreEqual(Default + Telephone, result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentPostCode() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).PostCode("postcode").ToHtmlString();

            //assert
            Assert.AreEqual(Default + PostCode, result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentFax() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Fax("fax").ToHtmlString();

            //assert
            Assert.AreEqual(Default + Fax, result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentName() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Name("name").ToHtmlString();

            //assert
            Assert.AreEqual(Default + Name, result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentDescription() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Description("description").ToHtmlString();

            //assert
            Assert.AreEqual(Default + Description, result, ignoreCase: true);

        }


        [TestMethod]
        public void ShouldCreateFluentCountry() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).Country(CountryCode.GB).ToHtmlString();

            //assert
            Assert.AreEqual(Default + Country, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeDefault() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode().ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeDefault, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.NONE, 200).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeValue, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeREFUSED() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.REFUSED).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeREFUSED, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeAUTHORISED() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.AUTHORISED).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeAUTHORISED, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeCAPTURED() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.CAPTURED).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeCAPTURED, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeERROR() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.ERROR).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeERROR, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeREFUSEDValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.REFUSED, 200).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeREFUSEDValue, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeAUTHORISEDValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.AUTHORISED, 200).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeAUTHORISEDValue, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeCAPTUREDValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.CAPTURED, 200).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeCAPTUREDValue, result, ignoreCase: true);

        }

        [TestMethod]
        public void ShouldCreateFluentTestModeERRORValue() {

            var html = HtmlHelperFactory.Create();

            //act
            var result = html.WorldPay("installation", "cart", "amount", CurrenyCode.GBP).TestMode(TestModeResult.ERROR, 200).ToHtmlString();

            //assert
            Assert.AreEqual(Default + TestModeERRORValue, result, ignoreCase: true);

        }
    }
}
