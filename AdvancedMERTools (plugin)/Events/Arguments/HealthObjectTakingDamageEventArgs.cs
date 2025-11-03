using AdvancedMERTools.Features.CustomObjects;
using LabApi.Events.Arguments.Interfaces;
using LabApi.Features.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMERTools.Events.Arguments
{
    public class HealthObjectTakingDamageEventArgs : EventArgs, IPlayerEvent, ICancellableEvent
    {
        public HealthObject HealthObject { get; set; }
        public HODTO HODTO { get; set; }
        public Player Player { get; set; }
        public bool IsAllowed { get; set; } = true;

        public HealthObjectTakingDamageEventArgs(HODTO hodto, Player attacker, HealthObject healthObject)
        {
            HealthObject = healthObject;
            HODTO = hodto;
            Player = attacker;
        }
    }
}
