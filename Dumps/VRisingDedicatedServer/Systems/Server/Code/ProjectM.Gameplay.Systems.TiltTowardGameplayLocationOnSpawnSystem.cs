using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.GetOwnerRotationOnSpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TiltTowardGameplayLocationOnSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1456215847_0;
    EntityQuery __query_1456215847_1;
    EntityQuery __query_1456215847_2;
    EntityQuery __query_1456215847_3;
    
    // unmanaged system, skipped generating example queries

}
