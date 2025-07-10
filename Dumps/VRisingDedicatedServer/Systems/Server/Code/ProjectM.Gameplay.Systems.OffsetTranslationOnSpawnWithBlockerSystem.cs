using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.OffsetTranslationOnSpawnSystem))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.GetOwnerRotationOnSpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct OffsetTranslationOnSpawnWithBlockerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1844768193_0;
    
    // unmanaged system, skipped generating example queries

}
