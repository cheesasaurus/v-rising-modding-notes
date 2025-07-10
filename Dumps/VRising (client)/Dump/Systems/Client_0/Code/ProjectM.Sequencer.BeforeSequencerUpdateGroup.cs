using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
public class BeforeSequencerUpdateGroup : ComponentSystemGroup
{

}
