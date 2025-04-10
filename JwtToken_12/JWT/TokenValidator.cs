using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JwtToken_12.JWT
{
    public class TokenValidator
    {
        public ClaimsPrincipal ValidatorJwtToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("20Derste20ProjeKampı+-*/0606tokenJWT");
            try
            {
                //ValidateToken ile tokenımızın geçerliliğini kontrol ediyoruz.
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey=true, //ValidateIssuerSigningKey secirty key ile tokenın kontrolünü çağırmak ister misin demek yes biz çağırıyoruz.
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer=true,
                    ValidIssuer="localhost",
                    ValidateAudience=true,
                    ValidAudience="localhost",
                    ValidateLifetime=true, //ValidateLifetime token süresi bitince geçersiz kalsın mı/evet demiş olduk
                    ClockSkew = TimeSpan.Zero, //ClockSkew,JWT doğrulama sırasında zaman uyuşmazlıklarına karşı tanınan tolerans süresidir.

                },out SecurityToken validatedToken);
                //C# dilinde out anahtar kelimesi, bir metottan birden fazla değer döndürmek için kullanılır.
                return principal;
                
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
