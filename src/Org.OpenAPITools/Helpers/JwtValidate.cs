using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using JWT.Algorithms;
using JWT.Builder;

namespace Org.OpenAPITools.Helpers
{
    public  class JwtValidate
    {
        public int? ValidateToken(string token)
        {
            if(token == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = ""; // Encoding.ASCII.GetBytes(_appSettings.Secret);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    //IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = System.TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

                return userId;
            }
            catch
            {
                return null;
            }
        }

        public bool validateToken(string token)
        {
            try
            {
                X509Certificate2 certificate = new X509Certificate2("KeyCloakRealm.Public.crt");

                RSACryptoServiceProvider key = (RSACryptoServiceProvider)certificate.PublicKey.Key;
                RSAParameters rsaParameters = key.ExportParameters(false);

                RSA rsa = RSA.Create();
                rsa.ImportParameters(rsaParameters);

                var json = JwtBuilder.Create()
                         .WithAlgorithm(new RS256Algorithm(rsa)) // asymmetric
                         .MustVerifySignature()
                         .Decode(token);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
