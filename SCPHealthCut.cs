using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace SCPHealthCut {
    public class SCPHealthCut : Plugin<Config> {
        internal GenHandler GenHandler { get; private set; };

        public override string Name => "SCP Health Cut";
        public override string Author => "Dogel";
        public override string Prefix => "SCP-HC";
        public override Version Version => new Version(1,0,0);

        public override void OnEnabled() {
            try {
                base.OnEnabled();
            } catch (Exception e) {
                Log.Error($"There was an error loading SCPHealthCut: {e}");
            }
        }

        public override void OnDisabled() {
            base.OnDisabled();
        }

        protected override void SubscribeEvents() {
            GenHandler = new(Config);

            Exiled.Events.Handlers.Player.Spawned += GenHandler.OnSpawned;
        }

        protected override void UnsubscribeEvents() {
            Exiled.Events.Handlers.Player.Spawned -= GenHandler.OnSpawned;

            GenHandler = null;
        }
    }
}
