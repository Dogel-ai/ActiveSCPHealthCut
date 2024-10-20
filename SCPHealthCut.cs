using System;
using Exiled.API.Enums;
using Exiled.API.Features;

// TODO: Add docs
namespace SCPHealthCut
{
    /// <summary>
    /// Changes SCP's health based on the number of active players.
    /// </summary>
    public class SCPHealthCut : Plugin<Config>
    {
        public static readonly SCPHealthCut Singleton = new();

        private EventHandler eventHandler;

        public override string Name => "SCP Health Cut";
        public override string Author => "Dogel";
        public override string Prefix => "SCP-HC";
        public override Version Version => new Version(1, 0, 0);

        private SCPHealthCut() { }

        /// <summary>
        /// Gets the only existing instance of this plugin.
        /// </summary>
        public static SCPHealthCut Instance => Singleton;

        public override PluginPriority Priority { get; } = PluginPriority.Last;

        public override void OnEnabled()
        {
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        /// <summary>
        /// Registers the plugin events.
        /// </summary>
        private void RegisterEvents()
        {
            eventHandler = new EventHandler(Config);

            Exiled.Events.Handlers.Player.Spawned += eventHandler.OnSpawned;
        }

        /// <summary>
        /// Unregisters the plugin events.
        /// </summary>
        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.Spawned -= eventHandler.OnSpawned;

            eventHandler = null;
        }
    }
}
