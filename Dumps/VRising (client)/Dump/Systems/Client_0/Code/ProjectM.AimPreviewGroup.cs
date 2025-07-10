using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
public class AimPreviewGroup : ComponentSystemGroup
{

}
