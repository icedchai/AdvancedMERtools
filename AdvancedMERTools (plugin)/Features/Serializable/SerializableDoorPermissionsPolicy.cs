using Interactables.Interobjects.DoorUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMERTools.Features.Serializable
{
    public class SerializableDoorPermissionsPolicy
    {
        public DoorPermissionFlags RequiredPermissions { get; set; } = DoorPermissionFlags.None;

        public bool RequireAll { get; set; } = false;

        public bool Bypass2176 { get; set; } = false;

        public DoorPermissionsPolicy CreatePolicy()
        {
            return new DoorPermissionsPolicy(RequiredPermissions, RequireAll, Bypass2176);
        }
    }
}
