using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.AdditionalMaterialSystem))]
public class AdditionalMaterialSystem_Hybrid : SystemBase
{

}
