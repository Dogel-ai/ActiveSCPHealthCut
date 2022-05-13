using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace SubjectHealthModif {
    public class SubjectHealthModif : Plugin<Config> {
        public EventHandlers EventHandler;

        public override string Name => "SCP Health Modifier";
        public override string Author => "Dogel";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled() {
            try {
                EventHandler = new EventHandlers();
                Player.ChangingRole += EventHandler.OnRoleChange;
                base.OnEnabled();
            } catch (Exception e) {
                Log.Error($"There was an error loading SubjectHealthModif: {e}");
            }
        }

        public override void OnDisabled() {
            Player.ChangingRole -= EventHandler.OnRoleChange;
            EventHandler = null;
            base.OnDisabled();
        }
    }
}
