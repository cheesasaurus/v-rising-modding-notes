using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup))]
public class SequencerUpdateGroup : ComponentSystemGroup
{

}
