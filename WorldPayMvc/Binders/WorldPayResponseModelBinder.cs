using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WorldPayMvc.Models;

namespace WorldPayMvc.Binders {
    public class WorldPayResponseModelBinder : DefaultModelBinder {

        private readonly static string[] WorldPayCustomVariables = new string[] { "MC_", "M_", "CM_" };

        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType) {
            var type = typeof(WorldPayResponseModel);
            var model = Activator.CreateInstance(type) as WorldPayResponseModel;
            bindingContext.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(() => model, type);

            foreach (var key in controllerContext.HttpContext.Request.Form.AllKeys.Where(q => WorldPayCustomVariables.Any(v => q.StartsWith(v)))) {
                model.CustomProperties.Add(key, controllerContext.RequestContext.HttpContext.Request.Form.GetValues(key).First());
            }

            return model;
        }
    }
}
