using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.AdditionalMaterialSystem_Dots))]
[UpdateAfter(typeof(ProjectM.Sequencer.ParticleLifetimeSystem))]
public class MaterialPropertySystem : SystemBase
{

}
