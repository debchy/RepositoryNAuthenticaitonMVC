using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace CMS.Helpers
{
    public static class HtmlHelpers {
        public static IHtmlString reCaptcha(this HtmlHelper helper) {
            StringBuilder sb = new StringBuilder();
            string publickey = WebConfigurationManager.AppSettings["RecaptchaPublicKey"];
            sb.AppendLine("<script type=\"text/javascript\" src='https://www.google.com/recaptcha/api.js'></script>");
            sb.AppendLine("");
            sb.AppendLine("<div class=\"g-recaptcha\" data-sitekey=\"" + publickey + "\"></div>");
            return MvcHtmlString.Create(sb.ToString());

        }

        public static MvcHtmlString ShareButtons(this HtmlHelper helper, string Url, string ImageFullUrl, string Title, string SmallDescription)
        {
            if (!Url.ToLower().StartsWith("http"))
            {
                Url = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Host + (Url.StartsWith("/")?Url: "/"+Url);
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<div class='social-icons'>
                            <a href = 'javasctipt:;' rel='nofollow'  onclick=""MM_openBrWindow('https://www.facebook.com/sharer.php?s=100&p[url]="+ Url + @"&p[images][0]="+ ImageFullUrl + @"&p[title]="+ Title + @"&p[summary]="+ SmallDescription + @"', 'TEXTEDITOR', 'scrollbars=yes,resizable=yes,width=800,height=600')""><i class='fa fa-facebook' aria-hidden='true'></i></a>
                            <a href = 'javasctipt:;'  rel='nofollow'  onclick=""MM_openBrWindow('https://twitter.com/share?url=" + Url + @"&text=" + Title + @"', 'TEXTEDITOR', 'scrollbars=yes,resizable=yes,width=700,height=300')""><i class='fa fa-twitter' aria-hidden='true'></i></a>
                            <a href = 'javasctipt:;'  rel='nofollow'  onclick=""MM_openBrWindow('https://plus.google.com/share?url=" + Url + @"&text=" + Title + @"', 'TEXTEDITOR', 'scrollbars=yes,resizable=yes,width=700,height=300')""><i class='fa fa-google-plus' aria-hidden='true'></i></a>
                            <!--<a href = 'javasctipt:;' ><i class='fa fa-youtube-play' aria-hidden='true'></i></a>-->
                            <a href = 'javasctipt:;' rel='nofollow'  onclick=""MM_openBrWindow('http://www.linkedin.com/shareArticle?mini=true&url=" + Url + @"&title=" + Title + @"&summary=" + SmallDescription + @"', 'TEXTEDITOR', 'scrollbars=yes,resizable=yes,width=500,height=400')""><i class='fa fa-linkedin' aria-hidden='true'></i></a>
                        </div>");
            return MvcHtmlString.Create(sb.ToString());

        }

        public static MvcHtmlString ShareButtonsOnDetailsPage(this HtmlHelper helper, string Url, string ImageFullUrl, string Title, string SmallDescription)
        {
            if (!Url.ToLower().StartsWith("http"))
            {
                Url = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Host + (Url.StartsWith("/") ? Url : "/" + Url);
            }
            StringBuilder sb = new StringBuilder();
            
            sb.Append(@"<ul class='unstyled'>
                        <!--<li>
                            <a href='javascript:;' ><img src='/ui/media/elements/icon-like.jpg'></a>
                        </li>-->
                        <li>
                            <a href='javascript:;' rel='nofollow'  onclick=""MM_openBrWindow('https://www.facebook.com/sharer.php?s=100&p[url]=" + Url + @"&p[images][0]=" + ImageFullUrl + @"&p[title]=" + Title + @"&p[summary]=" + SmallDescription + @"', 'TEXTEDITOR', 'scrollbars=yes,resizable=yes,width=800,height=600')""><img src='/ui/media/elements/icon-share.jpg'></a>
                        </li>
                        <li>
                            <a href='javascript:;' rel='nofollow'  onclick=""MM_openBrWindow('https://twitter.com/share?url=" + Url + @"&text=" + Title + @"', 'TEXTEDITOR', 'scrollbars=yes,resizable=yes,width=700,height=300')""><img src='/ui/media/elements/icon-tweet.jpg'></a>
                        </li>
                        <li>
                            <a href='javascript:;' rel='nofollow'  onclick=""MM_openBrWindow('https://plus.google.com/share?url=" + Url + @"&text=" + Title + @"', 'TEXTEDITOR', 'scrollbars=yes,resizable=yes,width=700,height=300')""><img src='/ui/media/elements/icon-g-share.jpg'></a>
                        </li>
                    </ul>");

            return MvcHtmlString.Create(sb.ToString());

        }

    }
}

                