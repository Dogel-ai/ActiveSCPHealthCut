using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SubjectHealthModif {
    public class Config : IConfig {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;
        [Description("By how much should SCP's health be divided (optional)")]
        public int Modifier { get; set; } = 4;
    }
}
