using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;
using System.ComponentModel;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Synthesis.Bethesda.Commands;

namespace MadAborManual
{
    public record Settings
    {

        [SettingName("Engaging Combat")]
        public bool ECon { get; set; } = true; // Default is on

        [SettingName("Engaging Combat - MR Debuff in Seconds")]
        public int debuffnum { get; set; } = 4; // Default is on

        [SettingName("Spell Abssorption Rework")]
        public bool SAon { get; set; } = true; // Default is on


    }







}

