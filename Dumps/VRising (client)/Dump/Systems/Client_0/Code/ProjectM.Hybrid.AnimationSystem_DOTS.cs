using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AnimationSystem_DOTS : ISystem, ISystemCompilerGenerated
{

}
