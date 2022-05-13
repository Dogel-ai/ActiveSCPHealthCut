using Exiled.Events.EventArgs;
using Server = Exiled.API.Features.Server;

namespace SubjectHealthModif {
    public class EventHandlers : Config {
        public void OnRoleChange(ChangingRoleEventArgs ev) {
            if (ev.Player.IsScp) {
                int FreeSlots = Server.PlayerCount / Modifier;
                ev.Player.MaxHealth = (int)(ev.Player.Health / FreeSlots);
            }
        }
    }
}
