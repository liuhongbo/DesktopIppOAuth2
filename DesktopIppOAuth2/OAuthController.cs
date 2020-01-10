using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace DesktopIppOAuth2
{
    public class OAuthController : ApiController
    {
        public delegate void OAuthCallbackHandler(string code, string realmId, string state, string error);

        public event OAuthCallbackHandler OAuthCallbackEvent;

        public OAuthController()
        {
            this.OAuthCallbackEvent += OAuthConnector.Current.OAuthCallback;
        }

        public HttpResponseMessage Get(string code = null, string realmId = null, string state = null, string error = null)
        {
            OAuthCallbackEvent.Invoke(code, realmId, state, error);

            if (string.IsNullOrEmpty(error))
            {
                var response = Request.CreateResponse(HttpStatusCode.OK, "text/html");
                string content;
                if (string.IsNullOrEmpty(OAuthConnector.Current.SuccessView))
                {
                    content =
@"<!DOCTYPE html>
<html>
<head>
<title>DesktopIppOAuth2</title>
</head>
<body>
<h1 style='color:green;'>Success!</h1>
<p>You have authorized the application to connect to your QuickBooks online.</p>
</body>
</html>";
                }
                else
                {
                    content = OAuthConnector.Current.SuccessView;
                }
                response.Content = new StringContent(content, Encoding.UTF8, "text/html");
                return response;
            }
            else
            {
                var response = Request.CreateResponse(HttpStatusCode.OK, "text/html");
                string content;
                if (string.IsNullOrEmpty(OAuthConnector.Current.ErrorView))
                {
                    content =
$@"<!DOCTYPE html>
<html>
<head>
<title>DesktopIppOAuth2</title>
</head>
<body>
<h1 style='color:red;'>Error!</h1>
<p>Failed to connect to Quickbooks online: {error}</p>
</body>
</html>";
                }
                else
                {
                    content = OAuthConnector.Current.ErrorView;
                }
                response.Content = new StringContent(content, Encoding.UTF8, "text/html");
                return response;
            }
        }
    }
}
