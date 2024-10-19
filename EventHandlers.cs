using Exiled.Events.EventArgs;
using Exiled.API.Features;

// Currently, if an spc spawns and there is one player their hp is full.
// It decreases with increasing players, but should increase with decreasing players. Make it a reverse ratio.
// Include check for minumum and maximum hp in the config.
namespace SCPHealthCut {
    internal class GenHandler {
        private Config config;

        internal GenHandler(Config instance) {
            config = instance;
        }

        internal void OnSpawned(SpawnedEventArgs ev) {  
            if (ev.Player.IsScp) {
                ev.Player.Broadcast("It works")
                    float divider = Server.PlayerCount * Modifier;

                    int hp = ev.Player.MaxHealth / divider;

                    if (hp < ev.Player.MaxHealth && Limit) {
                        ev.Player.MaxHealth = hp;
                    }

                    
            }
        }
    }
}