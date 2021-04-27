using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPlugin_EXILED.Handlers
{
    class Player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            string message = TutorialPlugin.Instance.Config.LeftMessage.Replace("{player}", ev.Player.Nickname);
            Map.Broadcast(6, message);
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            string message = TutorialPlugin.Instance.Config.JoinedMessage.Replace("{player}", ev.Player.Nickname);
            Map.Broadcast(6, message);
        }

        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            if (ev.IsAllowed == false)
            {
                ev.Player.Broadcast(3, TutorialPlugin.Instance.Config.BoobyTrapMessage);
                ev.Player.Kill(DamageTypes.Lure);
            }
        }
    }
}
