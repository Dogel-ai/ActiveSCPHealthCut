using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

// TODO: Add docs
namespace SCPHealthCut
{
    internal sealed class EventHandler
    {
        private readonly Config config;

        public EventHandler(Config instance)
        {
            config = instance;
        }

        /// <summary>
        /// Calculates and applies the health modification.
        /// </summary>
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnSpawned(SpawnedEventArgs)">
        public void OnSpawned(SpawnedEventArgs ev)
        {
            Player target = ev.Player;
            if (target.IsScp)
            {
                // TODO: Add max and min bounds.
                //     : Remove hurt effect.
                //     : Fix hp gauge.
                float hpPerPlayer = target.MaxHealth / config.Divider;
                float calculatedHp = hpPerPlayer * Server.PlayerCount;

                target.Health = calculatedHp;
                target.MaxHealth = calculatedHp;

                Log.Debug($"Target: {target}");
                Log.Debug($"calculatedHp: {calculatedHp}");
                Log.Debug($"MaxHealth: {target.MaxHealth}");
                Log.Debug($"Health: {target.Health}");
            }
        }
    }
}