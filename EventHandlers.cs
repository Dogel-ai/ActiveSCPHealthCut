using Exiled.Events.EventArgs;
using MEC;

namespace SubjectHealthModif {
    public class EventHandlers : Config {
        public void OnSpawn(SpawnedEventArgs ev) {
            if (ev.Player.IsScp) {
                Timing.CallDelayed(1.5f, () => {
                    int hp = ev.Player.MaxHealth;
                    float Divider = Exiled.API.Features.Server.PlayerCount * Modifier;
                    ev.Player.Health /= Divider;
                    if (hp < ev.Player.MaxHealth && Limit) { ev.Player.MaxHealth = hp; }
                });
            }
        }
    }
}