using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;

using Logger = Rocket.Core.Logging.Logger;

namespace F.LogoUI
{
    public class Main : RocketPlugin<Config>
    {
        public static Main Instance;
        protected override void Load()
        {
            Instance = this;

            Logger.Log("####################################################", ConsoleColor.Red);
            Logger.Log("#                 F.LogoUI Loaded                  #", ConsoleColor.Red);
            Logger.Log("#                 Plugin By: Feli                  #", ConsoleColor.Red);
            Logger.Log("#    Discord Support:https://discord.gg/6zQVJ9p    #", ConsoleColor.Red);
            Logger.Log("#                 Plugin Ver: 1.0.0                #", ConsoleColor.Red);
            Logger.Log("####################################################", ConsoleColor.Red);
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            if(this.Configuration.Instance.LogoEnbled == false)
            {
                return;
            }
            else
            {
                EffectManager.sendUIEffect(this.Configuration.Instance.LogoUI, (short)32411, player.CSteamID, true);
                EffectManager.sendUIEffectImageURL(32411, player.CSteamID, true, "Image", this.Configuration.Instance.LogoURL);
            }
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
            Instance = null;
        }
    }
}
