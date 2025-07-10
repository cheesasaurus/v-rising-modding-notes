using Unity.Entities;

namespace ProjectM.CubeRenderer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.UIGroup))]
public class DebugCubeSystem : SystemBase
{

}
