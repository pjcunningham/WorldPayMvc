WorldPay ASP.NET Fluent MVC Helper
=================

# Form Submission #

### Given the following model ###

```c#

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

```

### With the following instance ###

```c#

public ActionResult Index() {

    var model = new CheckoutViewModel { 

        InstallationId = "YOUR_INSTALLATION_ID",
        CartId = "YOUR_CART_ID",
        Total = 100.00m,
        CurrencyCode = CurrencyCode.GBP,

        Address1 = "10 Downing Street",
        Town = "London",
        PostCode = "SW1A 2AA",
        CountryCode = CountryCode.GB,

        Name = "Prime Minister",
        Email = "dave@gov.uk",
        Telephone = "020 7925 0918"
    
    };

    return View(model);
}
```

### Using Test Mode ###

```c#

@using (Html.BeginForm(null, null, FormMethod.Post, new { @action = WorldPayUrls.Test })) {

    @(Html.WorldPay(@Model.InstallationId, @Model.CartId, @Model.Total.ToString(), @Model.CurrencyCode)
        .TestMode()
        .Address(@Model.Address1, @Model.Address2, @Model.Address3, @Model.Town, @Model.County, @Model.PostCode, CountryCode.GB)
        .Email(@Model.Email)
        .Name(@Model.Name)
        .Phones(@Model.Telephone))

    <div class="form-group">
        <button class="btn btn-success btn-lg" type="submit">WorldPay Test Checkout</button>
    </div>

}
```

### Results in the following HTML output ###

    <form action="https://secure-test.worldpay.com/wcc/purchase" method="post">
	    <input name="address1" type="hidden" value="10 Downing Street" />
	    <input name="amount" type="hidden" value="100.00" />
	    <input name="cartId" type="hidden" value="YOUR_CART_ID" />
	    <input name="country" type="hidden" value="GB" />
	    <input name="currency" type="hidden" value="GBP" />
	    <input name="email" type="hidden" value="dave@gov.uk" />
	    <input name="instId" type="hidden" value="YOUR_INSTALLATION_ID" />
	    <input name="name" type="hidden" value="Prime Minister" />
	    <input name="postcode" type="hidden" value="SW1A 2AA" />
	    <input name="tel" type="hidden" value="020 7925 0918" />
	    <input name="testMode" type="hidden" value="100" />
	    <input name="town" type="hidden" value="London" />    
	    <div class="form-group">
	        <button class="btn btn-success btn-lg" type="submit">WorldPay Test Checkout</button>
	    </div>
	</form>

### Using Live Mode ###

```c#

@using (Html.BeginForm(null, null, FormMethod.Post, new { @action = WorldPayUrls.Live })) {

    @(Html.WorldPay(@Model.InstallationId, @Model.CartId, @Model.Total.ToString(), @Model.CurrencyCode)
        .Address(@Model.Address1, @Model.Address2, @Model.Address3, @Model.Town, @Model.County, @Model.PostCode, CountryCode.GB)
        .Email(@Model.Email)
        .Name(@Model.Name)
        .Phones(@Model.Telephone))

    <div class="form-group">
        <button class="btn btn-success btn-lg" type="submit">WorldPay Live Checkout</button>
    </div>

}
```

### Results in the following HTML output ###

    <form action="https://secure.worldpay.com/wcc/purchase" method="post">
	    <input name="address1" type="hidden" value="10 Downing Street" />
	    <input name="amount" type="hidden" value="100.00" />
	    <input name="cartId" type="hidden" value="YOUR_CART_ID" />
	    <input name="country" type="hidden" value="GB" />
	    <input name="currency" type="hidden" value="GBP" />
	    <input name="email" type="hidden" value="dave@gov.uk" />
	    <input name="instId" type="hidden" value="YOUR_INSTALLATION_ID" />
	    <input name="name" type="hidden" value="Prime Minister" />
	    <input name="postcode" type="hidden" value="SW1A 2AA" />
	    <input name="tel" type="hidden" value="020 7925 0918" />
	    <input name="town" type="hidden" value="London" />    
	    <div class="form-group">
	        <button class="btn btn-success btn-lg" type="submit">WorldPay Live Checkout</button>
	    </div>
	</form>

### Custom Properties ###

```c#

@using (Html.BeginForm(null, null, FormMethod.Post, new { @action = WorldPayUrls.Test })) {

    @(Html.WorldPay(@Model.InstallationId, @Model.CartId, @Model.Total.ToString(), @Model.CurrencyCode)
        .TestMode()
        .Address(@Model.Address1, @Model.Address2, @Model.Address3, @Model.Town, @Model.County, @Model.PostCode, CountryCode.GB)
        .Email(@Model.Email)
        .Name(@Model.Name)
        .Phones(@Model.Telephone)
        .Add("accId1", "MERCHANTCODE2")
        .Add("MC_SHOPPINGCARTID", Guid.NewGuid().ToString())
        .Add("MC_CUSTOMERREFERENCE", "My Purchase Order")
        .Add("MC_CUSTOMERID", Guid.NewGuid().ToString()))

    <div class="form-group">
        <button class="btn btn-success btn-lg" type="submit">WorldPay Test Checkout</button>
    </div>

}
```

### Results in the following HTML output ###

	<form action="https://secure-test.worldpay.com/wcc/purchase" method="post">
	    <input name="address1" type="hidden" value="10 Downing Street" />
	    <input name="amount" type="hidden" value="100.00" />
	    <input name="cartId" type="hidden" value="YOUR_CART_ID" />
	    <input name="country" type="hidden" value="GB" />
	    <input name="currency" type="hidden" value="GBP" />
	    <input name="email" type="hidden" value="dave@gov.uk" />
	    <input name="instId" type="hidden" value="YOUR_INTSALLATION_ID" />
	    <input name="name" type="hidden" value="Prime Minister" />
	    <input name="postcode" type="hidden" value="SW1A 2AA" />
	    <input name="tel" type="hidden" value="020 7925 0918" />
	    <input name="testMode" type="hidden" value="100" />
	    <input name="town" type="hidden" value="London" />
	    <input name="accId1" type="hidden" value="MERCHANTCODE2" />
	    <input name="MC_SHOPPINGCARTID" type="hidden" value="a2c6b0a9-178a-4743-8fde-66a70e7a138b" />
	    <input name="MC_CUSTOMERREFERENCE" type="hidden" value="My Purchase Order" />
	    <input name="MC_CUSTOMERID" type="hidden" value="1d1a5284-f872-402a-b2d8-f605a277a27f" />    
	    <div class="form-group">
	        <button class="btn btn-success btn-lg" type="submit">WorldPay Test Checkout</button>
	    </div>
	</form>

# Callbacks #

### The helper defines the following WorldPayResponseModel class ###

```c#
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
        public string cardTyp { get; set; }
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
```

### So given the following inherited model ###

```c#
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
```

### Use the following Action to process the callback ###

```c#
[HttpPost]
[ValidateInput(false)]
public ActionResult Index(CustomWorldPayResponseViewModel model) {

    // Password Check - Password is set in the WorldPay installation settings
    if (model.callbackPW != "My Secret Password") {
        return View("Error", model);
    }

#if(DEBUG)

    PropertyInfo[] properties = model.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

    foreach (var property in properties.OrderBy(q => q.Name)) {
        Debug.WriteLine("Model Property {0}; Value : {1}", property.Name, property.GetValue(model));                
    }

    foreach (var keyValue in model.CustomProperties) {
        Debug.WriteLine("Custom Property {0}; Value : {1}", keyValue.Key, keyValue.Value);
    }


#endif        

    if (model.transStatus == "Y") {
        return View("Success", GenerateSuccessViewModel(model));
    } else {
        return View("Failure", GenerateFailureViewModel(model));
    }

}
```