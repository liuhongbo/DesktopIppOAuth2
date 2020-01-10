using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopIppOAuth2;
using Intuit.Ipp.OAuth2PlatformClient;

namespace DesktopIppOAuthSample
{
    public partial class FormMain : Form
    {
        private string _clientID;
        private string _clientSecret;
        private string _redirectURI;
        private string _state;
        private string _environment;
        private List<OidcScopes> _scopes = new List<OidcScopes>();
        private string _baseAddress;

        private DesktopIppOAuth2.OAuthConnector _connector;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _scopes.AddRange(new OidcScopes[] { OidcScopes.Accounting, OidcScopes.OpenId, OidcScopes.Email, OidcScopes.Phone });
            _baseAddress = @"http://localhost:65521/";
            _connector = new OAuthConnector();
            _connector.IppOAuthResultEvent += _connector_IppOAuthResultEvent;
            _connector.IppOAuthErrorEvent += _connector_IppOAuthErrorEvent;
        }

        private void _connector_IppOAuthErrorEvent(string error, string state)
        {
            SafeInvokeHelper.Invoke(textBoxError, "set_Text", error);
            SafeInvokeHelper.Invoke(textBoxState2, "set_Text", state);
        }

        void _connector_IppOAuthResultEvent(string accessToken, string refreshToken, long accessTokenExpiresIn, string realmId, string state)
        {
            SafeInvokeHelper.Invoke(textBoxRealmId, "set_Text", realmId);
            SafeInvokeHelper.Invoke(textBoxAccessTokenExpiresIn, "set_Text", accessTokenExpiresIn.ToString());
            SafeInvokeHelper.Invoke(textBoxAccessToken, "set_Text", accessToken);
            SafeInvokeHelper.Invoke(textBoxRefreshToken, "set_Text", refreshToken);
            SafeInvokeHelper.Invoke(textBoxState2, "set_Text", state);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connector.Clean();
        }      

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _clientID = textBoxClientID.Text;
            _clientSecret = textBoxClientSecret.Text;
            _redirectURI = textBoxRedirectUrl.Text;
            _state = textBoxState.Text;
            _environment = textBoxEnvironment.Text;   
            
            _connector.Connect(_clientID, _clientSecret, _redirectURI, _state, _environment, _scopes, _baseAddress);            
        }       
    }
}
