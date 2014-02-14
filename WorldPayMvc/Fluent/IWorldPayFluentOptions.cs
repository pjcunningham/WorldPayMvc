using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldPayMvc {
    public interface IWorldPayFluentOptions : IHtmlString {
        IWorldPayFluentOptions PostCode(string value);
        IWorldPayFluentOptions Telephone(string value);
        IWorldPayFluentOptions Fax(string value);
        IWorldPayFluentOptions Email(string value);
        IWorldPayFluentOptions Name(string value);
        IWorldPayFluentOptions Description(string value);
        IWorldPayFluentOptions Country(CountryCode code);
        IWorldPayFluentOptions TestMode(TestModeResult tmResult = TestModeResult.NONE, int value = 100);
    }
}
