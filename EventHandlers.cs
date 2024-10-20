using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

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
                // TODO: Remove hurt effect.
                //     : Fix hp gauge.
                //     : AHP cut.

                float hpFraction = target.MaxHealth / config.Divider;
                float calculatedHp = hpFraction * Server.PlayerCount;

                if (calculatedHp < config.Minimum && config.Bounds)
                {
                    calculatedHp = config.Minimum;
                }
                else if (calculatedHp > config.Maximum && config.Bounds)
                {
                    calculatedHp = config.Maximum;
                }

                target.Health = calculatedHp;
                target.MaxHealth = calculatedHp;

                Log.Debug($"Target: {target}");
                Log.Debug($"calculatedHp: {calculatedHp}");
                Log.Debug($"Health: {target.Health}");
            }
        }
    }
}