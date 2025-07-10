using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
public class GetHybridDataGroup : ComponentSystemGroup
{

}
