using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
public class SequencerPresentationGroup : ComponentSystemGroup
{

}
