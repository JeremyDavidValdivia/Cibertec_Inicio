using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(double price)
        {
            var result = string.Empty;
            if (price == 0.0)
                result = "<span>Price : Free!!!</span>";
            else
                result = $"<span>Price : {price}</span>";
            return new HtmlString(result);
        }
        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            var result = string.Empty;
            if (price == 0.0)
                result = "<span>Price : Free!!!</span>";
            else
                result = $"<span>Price : {price}</span>";
            return new HtmlString(result);
        }

        private static string GetDateTime(DateTime? CreateDate)
        {
            return (CreateDate == null) ? "none" : CreateDate.Value.ToString("dd/MM/yyyy");
        }

        public static IHtmlString DisplayDateOrNullStatic(DateTime? CreateDate)
        {
            return new HtmlString($"<span>{GetDateTime(CreateDate)}</span>");
        }

        public static IHtmlString DisplayDateOrNullStaticExtension(this HtmlHelper helper, DateTime? CreateDate)
        {
            return new HtmlString($"<span>{GetDateTime(CreateDate)}</span>");
        }

        //public static IHtmlString DisplayDateOrNullStatic(DateTime? CreateDate)
        //{
        //    var result = string.Empty;
        //    if (CreateDate != null)
        //    {
        //        result = $"<span>Date Static : {CreateDate.Value.ToString("dd/MM/yyyy")}</span>";
        //    }
        //    else
        //        result = "<span>Date Static : </span>";
        //    return new HtmlString(result);
        //}


        //public static IHtmlString DisplayDateOrNullStaticExtension(this HtmlHelper helper, DateTime? CreateDate)
        //{
        //    var result = string.Empty;
        //    if (CreateDate != null)
        //        result = $"<span>Date Extension : {CreateDate.Value.ToString("dd/MM/yyyy")}</span>";
        //    else
        //        result = "<span>Date Extension : </span>";
        //    return new HtmlString(result);
        //}

    }
}
