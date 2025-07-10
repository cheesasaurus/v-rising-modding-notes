using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.HideMaterialSystem_Dots))]
[UpdateAfter(typeof(ProjectM.Sequencer.MaterialPropertySystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AnimateFadeOutSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    
    // unmanaged system, skipped generating example queries

}
