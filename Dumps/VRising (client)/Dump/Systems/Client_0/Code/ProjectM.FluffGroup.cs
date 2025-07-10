using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
[UpdateBefore(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
[UpdateAfter(typeof(ProjectM.CameraPresentationGroup))]
public class FluffGroup : ComponentSystemGroup
{

}
