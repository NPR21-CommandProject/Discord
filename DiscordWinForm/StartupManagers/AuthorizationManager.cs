using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace DiscordWinForm.StartupManagers
{
    public class AuthorizationManager
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthorizationManager(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public AuthorizationManager() { }

        public void Serialize()
        {
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "appUserInfo.json"), JsonSerializer.Serialize(this));
        }

        public bool Deserialize()
        {
            string text = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appUserInfo.json"));
            if (text != string.Empty)
            {
                AuthorizationManager user = JsonSerializer.Deserialize<AuthorizationManager>(text);
                Username = user.Username;
                Password = user.Password;
                return Username != string.Empty && Password != string.Empty;
            }
            return false;
        }
    }


}
