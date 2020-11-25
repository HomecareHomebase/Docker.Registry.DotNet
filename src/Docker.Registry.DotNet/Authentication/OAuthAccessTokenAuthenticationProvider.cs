using Docker.Registry.DotNet.OAuth;
using JetBrains.Annotations;

namespace Docker.Registry.DotNet.Authentication
{
    [PublicAPI]
    public class OAuthAccessTokenAuthenticationProvider : PasswordOAuthAuthenticationProvider
    {
        public OAuthAccessTokenAuthenticationProvider(string username, string password)
            : base(username, password)
        {
        }

        internal override string GetToken(OAuthToken token) => token.AccessToken;
    }
}