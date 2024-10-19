using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SCPHealthCut {
    public class Config : IConfig {

        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("By how much should SCP's health be divided (optional)")]
        public float Modifier { get; set; } = 1f;

        [Description("Whether or not there should be a limit to SCP's max hp.")]
        public bool Limit { get; set; } = true;
        
    }
}
