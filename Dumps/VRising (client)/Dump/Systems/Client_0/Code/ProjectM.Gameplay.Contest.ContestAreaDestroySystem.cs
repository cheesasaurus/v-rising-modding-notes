using Unity.Entities;

namespace ProjectM.Gameplay.Contest;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestAreaDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestAreaDestroyQuery;
    EntityQuery __query_2119395396_0;
    EntityQuery __query_2119395396_1;
    
    // unmanaged system, skipped generating example queries

}
