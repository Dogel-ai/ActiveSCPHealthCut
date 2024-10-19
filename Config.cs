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

        [Description("The amount that SCP's health is divided by. (Recommended the server's player cap)")]
        public float Divider { get; set; } = 1f;
    }
}
