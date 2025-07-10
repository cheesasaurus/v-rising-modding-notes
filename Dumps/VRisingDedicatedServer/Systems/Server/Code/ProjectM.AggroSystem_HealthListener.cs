using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.StatChangeSystem))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.StatChangeMutationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AggroSystem_HealthListener : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1809977835_0;
    EntityQuery __query_1809977835_1;
    EntityQuery __query_1809977835_2;
    
    // unmanaged system, skipped generating example queries

}
