using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.MaterialChangeSystem))]
public class MaterialChangeSystem_Dots : SystemBase
{

}
