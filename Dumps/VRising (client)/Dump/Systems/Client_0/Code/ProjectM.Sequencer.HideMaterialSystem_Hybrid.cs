using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.HideMaterialSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.MaterialChangeSystem_Hybrid))]
[UpdateAfter(typeof(ProjectM.Sequencer.AdditionalMaterialSystem_Hybrid))]
public class HideMaterialSystem_Hybrid : SystemBase
{

}
