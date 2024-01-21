using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace DiscordWinForm.Helpers
{
    public class UserAuthorizationHelper
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserAuthorizationHelper(string username, string password) {
            Username = username;
            Password = password;
        }

        public UserAuthorizationHelper() { }

        public void Serialize()
        {
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "appUserInfo.json"), JsonSerializer.Serialize(this));
        }
    
        public bool Deserialize()
        {
            string text = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appUserInfo.json"));
            if (text != string.Empty)
            {
                UserAuthorizationHelper user = JsonSerializer.Deserialize<UserAuthorizationHelper>(text);
                Username = user.Username;
                Password = user.Password;
                return Username != string.Empty && Password != string.Empty;
            }
            return false;        
        }
    }


}
