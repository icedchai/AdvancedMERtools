using Interactables.Interobjects.DoorUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMERTools
{
    public class InteractableObjectDoorPermissionRequester : IDoorPermissionRequester
    {
        public InteractableObjectDoorPermissionRequester() { }

        public DoorPermissionsPolicy PermissionsPolicy { get; set; }

        public string RequesterLogSignature { get; set; }
    }
}
