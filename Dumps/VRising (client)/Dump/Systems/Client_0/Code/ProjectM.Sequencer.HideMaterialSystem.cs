using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.ParticleLifetimeSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
public class HideMaterialSystem : SystemBase
{

}
