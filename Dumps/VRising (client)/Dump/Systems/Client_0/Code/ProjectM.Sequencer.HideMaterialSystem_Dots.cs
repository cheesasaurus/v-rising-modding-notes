using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.HideMaterialSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.AdditionalMaterialSystem_Dots))]
[UpdateAfter(typeof(ProjectM.Sequencer.MaterialChangeSystem_Dots))]
public class HideMaterialSystem_Dots : SystemBase
{

}
