using Rocket.API;

namespace F.LogoUI
{
    public class Config : IRocketPluginConfiguration
    {
        public ushort LogoUI;
        public string LogoURL;
        public bool LogoEnabled;

        public void LoadDefaults()
        {
            LogoUI = (ushort)32410;
            LogoURL = "https://i.imgur.com/0M2kAwf.png";
            LogoEnabled = true;
        }
    }
}
