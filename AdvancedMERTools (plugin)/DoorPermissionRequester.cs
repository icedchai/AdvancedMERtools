using Interactables.Interobjects.DoorUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMERTools
{
    public class DoorPermissionRequester : IDoorPermissionRequester
    {
        public DoorPermissionRequester() { }

        public DoorPermissionsPolicy PermissionsPolicy { get; set; }

        public string RequesterLogSignature { get; set; }
    }
}
