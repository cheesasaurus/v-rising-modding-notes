using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.MaterialPropertySystem))]
public class MaterialPropertySystem_Hybrid : SystemBase
{

}
