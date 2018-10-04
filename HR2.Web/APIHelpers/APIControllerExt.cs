using HR2.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HR2.Web.APIHelpers
{
    public static partial class APIControllerExt
    {
        /// <summary>
        /// Returns array of toasts based on model state errors
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="showAutomatically">true means, error will be shown in toastr by global ajax handler, false means programmer will handle it on its own</param>
        /// <param name="trimKeyName">trims keyName to just name instead of including typename along with the field name. for example TaskType.Name will be used as Name instead of taskType.Name if this parameters is true</param>
        /// <returns></returns>        
        public static Toast[] GetModelStateErrors(this ApiController controller, bool showAutomatically, bool trimKeyName = true)
        {
            List<Toast> lstErrors = new List<Toast>();

            controller.ModelState.Where(m => m.Value.Errors.Count > 0)
                .ToList().ForEach(
                k =>
                {
                    k.Value.Errors.ToList().ForEach(
                    e =>
                    {
                        string key = k.Key;
                        if (key.Contains('.'))
                        {
                            string[] arrKeys = key.Split('.');
                            key = arrKeys[arrKeys.Length - 1];
                        }
                        lstErrors.Add(new Toast(e.ErrorMessage, ToastType.Error) { Show = showAutomatically, MessageFor = key });
                    }
                    );
                }
                );

            return lstErrors.ToArray();
        }
    }
}