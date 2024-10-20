using Exiled.API.Interfaces;
using System.ComponentModel;

// TODO: Add docs
namespace SCPHealthCut
{
    public sealed class Config : IConfig
    {

        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;

        [Description("The amount that SCP's health is divided by. (Advised value is server's player cap)")]
        public float Divider { get; set; } = 1f;

        [Description("Minimum and maximum amount of health that an SCP can have.")]
        public bool Bounds { get; set; } = false;
        public float Minimum { get; set; }
        public float Maximum { get; set; } 
    }
}
