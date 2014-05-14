using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldPayMvc {
    public interface IWorldPayFluentOptions : IHtmlString {
        IWorldPayFluentOptions Address(string address1, string address2, string address3, string town, string region, string postcode, CountryCode countryCode);
        IWorldPayFluentOptions Phones(string telephone, string fax = null);
        IWorldPayFluentOptions Email(string value);
        IWorldPayFluentOptions Name(string name, string Description = null);
        IWorldPayFluentOptions TestMode(TestModeResult tmResult = TestModeResult.NONE, int value = 100);
        IWorldPayFluentOptions Add(string propertyName, string value);
    }
}
