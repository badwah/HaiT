using System;
using System.Collections.Generic;
using System.Web;

namespace HaiT.MainWebsite.Common
{
    public static class SplashHelper
    {

        public const string SplashCookieName = "HaiTSplashCookie";

        public static void SetSplashCookie(HttpRequestBase request, HttpResponseBase response)
        {
            if (!HasSplashCookie(request))
            {
                var splashCookie = new HttpCookie(SplashCookieName) {Expires = DateTime.Now.AddSeconds(30), Value = "Hy"};
                response.Cookies.Add(splashCookie);
            }
        }

        public static bool HasSplashCookie(HttpRequestBase request)
        {
            
            var cookieNames = new List<string>(request.Cookies.AllKeys);
            return (cookieNames.Contains(SplashCookieName));
        }
    }
}