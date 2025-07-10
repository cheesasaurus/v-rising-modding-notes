using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
[UpdateBefore(typeof(ProjectM.AudioGroup))]
public class UIGroup : ComponentSystemGroup
{

}
