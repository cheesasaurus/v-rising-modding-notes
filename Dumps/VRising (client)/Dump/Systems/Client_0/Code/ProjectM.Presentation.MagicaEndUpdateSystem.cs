using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderLast = true)]
[UpdateAfter(typeof(ProjectM.UIGroup))]
public class MagicaEndUpdateSystem : SystemBase
{

}
