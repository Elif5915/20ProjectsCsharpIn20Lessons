using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JwtToken_12.JWT
{
    public class TokenGenerator
    {
        public string GenerateJwtToken(string username,string email,string name,string surname)
        {
            // burası token üretecek olan method
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeKampı+-*/0606tokenJWT"));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            var claimsExample = new[] //claim dediğimiz şey bizim token oluşturmak için istekte bulunacak kişimiz
            {
                new Claim(JwtRegisteredClaimNames.Sub,username), //sub, id için kullanılan parametre
                new Claim(JwtRegisteredClaimNames.Email,email),
                new Claim(JwtRegisteredClaimNames.GivenName,name),
                new Claim(JwtRegisteredClaimNames.FamilyName,surname),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())//Jti
            };
            var token = new JwtSecurityToken(
                issuer: "localhost", // issuer benim tokenımın yayınlayıcı, web tabanlı uygulamalarda dinleyici normalde localhost oluyor.
                audience: "localhost", //dinleyici
                claims: claimsExample,
                expires: DateTime.Now.AddMinutes(5), //expires tokenın geçerlilik süresi ne kadar olduğunu belirtir.Burada biz beş dk olarak verdik
                signingCredentials: credentials //bu da token algoritmasını tutacak kısım
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public string GenerateJwtToken2(string username)
        {
            // burası token üretecek olan method
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeKampı+-*/0606tokenJWT"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claimsExample = new[] //claim dediğimiz şey bizim token oluşturmak için istekte bulunacak kişimiz
            {
                new Claim(JwtRegisteredClaimNames.Sub,username), //sub, id için kullanılan parametre
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())//Jti
            };
            var token = new JwtSecurityToken(
                issuer: "localhost", // issuer benim tokenımın yayınlayıcı, web tabanlı uygulamalarda dinleyici normalde localhost oluyor.
                audience: "localhost", //dinleyici
                claims: claimsExample,
                expires: DateTime.Now.AddMinutes(5), //expires tokenın geçerlilik süresi ne kadar olduğunu belirtir.Burada biz beş dk olarak verdik
                signingCredentials: credentials //bu da token algoritmasını tutacak kısım
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
