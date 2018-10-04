using HR2.Utility;
using HR2.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HR2.Web.APIHelpers;
using System.Web.Http.Cors;

namespace HR2.Web.Controllers
{
    ////#if !DEBUG
    ////    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*", SupportsCredentials = true)]
    ////#else
    ////    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*", SupportsCredentials = true)]
    ////#endif

    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*", SupportsCredentials = true)]
    public class GuestBaseController : ApiController
    {
        public GuestBaseController()
        {
        }
        protected APIResult ModelStateErrors()
        {
            APIResult result = new APIResult(null, success: false, messages: this.GetModelStateErrors(false));
            result.AutoShowMessages.Add(new Toast("There is some error in data submitted. Please correct and try again.", ToastType.Error));
            return result;
        }

        protected APIResult DataKeyValueErrors(DataKeyValueException ex, bool showInstructions)
        {
            List<Toast> errors = new List<Toast>();
            foreach (var error in ex.DataErrors)
            {
                errors.Add(new Toast(error.Value, ToastType.Error) { MessageFor = error.Key, Show = false });
            }
            if (showInstructions)
                errors.Add(new Toast("There is some error in data submitted. Please correct and try again.", ToastType.Error));
            return new APIResult(success: false, messages: errors.ToArray());
        }

        protected APIResult DataToastErrors(DataToastException ex, bool showInstructions)
        {
            if (showInstructions)
                ex.DataErrors[ex.DataErrors.Length] = new Toast("There is some error in data submitted. Please correct and try again.", ToastType.Error);
            return new APIResult(null, false, false, ex.DataErrors);
        }
    }
}
