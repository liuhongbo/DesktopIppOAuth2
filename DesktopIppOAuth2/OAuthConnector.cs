using System;
using System.Threading.Tasks;
using System.Threading;
using Intuit.Ipp.OAuth2PlatformClient;
using System.Collections.Generic;
using System.Web;
#if NET40
using System.Web.Http.SelfHost;
#else
using Microsoft.Owin.Hosting;
#endif

namespace DesktopIppOAuth2
{
    public class OAuthConnector
    {
        public static OAuth2Client oauthClient;

        public delegate void IppOAuthResultHandler(string accessToken, string refreshToken, long accessTokenExpiresIn, string realmId, string state);
        public delegate void IppOAuthErrorHandler(string error, string state);
        public event IppOAuthResultHandler IppOAuthResultEvent;
        public event IppOAuthErrorHandler IppOAuthErrorEvent;

        IDisposable _webApp = null;
        
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectURI { get; set; }
        public string Environment { get; set; }
        public string State { get; set; }
        public List<OidcScopes> Scopes { get; set; }  = new List<OidcScopes>();
        public static OAuthConnector Current { get; set; }       
        public string BaseAddress { get; set; } = @"http://localhost:65521/";
        public string RealmId { get; set; }        
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long AccessTokenExpiresIn { get; set; }
        public string SuccessView { get; set; }
        public string ErrorView { get; set; }

        public void Connect(string clientID, string clientSecret, string redirectURI, string state, string environment, List<OidcScopes> scopes, string baseAddress)
        {
            try
            {
                ClientID = clientID;
                ClientSecret = clientSecret;
                RedirectURI = redirectURI;
                State = state;

                Environment = environment;
                if (!string.IsNullOrEmpty(baseAddress))
                {
                    BaseAddress = baseAddress;
                }

                if (Current != null)
                {
                    Current.Clean();
                }
                Current = this;

                oauthClient = new OAuth2Client(ClientID, ClientSecret, RedirectURI, Environment);
                _webApp = WebApp.Start<Startup>(url: BaseAddress);

                Scopes = scopes;

                //Get the authorization URL
                string authorizeUrl = oauthClient.GetAuthorizationURL(scopes, State);

                // Redirect user to Intuit for Auth            
                string uri = HttpUtility.UrlDecode(authorizeUrl);
                System.Diagnostics.Process.Start(uri);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void OAuthCallback(string code, string realmId, string state, string error)
        {
            if (string.IsNullOrEmpty(error))
            {
                RealmId = realmId;

                // Use the request token and auth verifier to get an access token           
                try
                {
                    // Get OAuth2 Bearer token
                    var tokenResponse = oauthClient.GetBearerTokenAsync(code).Result;

                    AccessToken = tokenResponse.AccessToken;
                    RefreshToken = tokenResponse.RefreshToken;
                    AccessTokenExpiresIn = tokenResponse.RefreshTokenExpiresIn;

                    if (IppOAuthResultEvent != null)
                    {
                        IppOAuthResultEvent.Invoke(AccessToken, RefreshToken, AccessTokenExpiresIn, RealmId, state);
                    }
                    Task.Run(() =>
                    {
                        Task.Delay(2000).Wait();
                        Clean();
                    });
                }
                catch (Exception ex)
                {
                    Clean();
                    throw ex;
                }
            }
            else
            {
                if (IppOAuthErrorEvent != null)
                {
                    IppOAuthErrorEvent.Invoke(error, state);
                }
                Task.Run(() =>
                {
                    Task.Delay(2000).Wait();
                    Clean();
                });                
            }
        }

        public void Clean()
        {
            if (_webApp != null)
            {
                _webApp.Dispose();
                _webApp = null;
            }
            Current = null;
        }        
    }
}
