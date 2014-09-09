WorldPay ASP.NET Fluent MVC Helper
=================

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

### Results in the following HTML Output ###

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