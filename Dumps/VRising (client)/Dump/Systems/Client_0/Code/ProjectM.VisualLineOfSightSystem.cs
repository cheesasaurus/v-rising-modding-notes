using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.CameraPresentationGroup))]
public class VisualLineOfSightSystem : SystemBase
{

}
