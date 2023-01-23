using Hooks.ActualHooks.GrapplingHook;
using UnityEngine;

namespace Extensions
{
    public static class SpringJointExtensions
    {
        public static void ApplyGrapplingHookJointSettings(this SpringJoint joint, GrapplingHookJointSettings settings)
        {
            joint.anchor = settings.anchor;
            joint.autoConfigureConnectedAnchor = settings.autoConfigureConnectedAnchor;
            joint.connectedAnchor = settings.connectedAnchor;
            joint.spring = settings.spring;
            joint.damper = settings.damper;
        }
    }
}
