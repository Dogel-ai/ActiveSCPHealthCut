using Exiled.Events.EventArgs;
using Server = Exiled.API.Features.Server;

namespace SubjectHealthModif {
    public class EventHandlers : Config {
        public void OnSpawn(SpawnedEventArgs ev) {
            if (ev.Player.IsScp) {
                float hp = ev.Player.MaxHealth;
                float Divider = Server.PlayerCount / Modifier;
                ev.Player.Health /= Divider;
                if (hp < ev.Player.MaxHealth) { ev.Player.Health = hp; }
            }
        }
    }
}