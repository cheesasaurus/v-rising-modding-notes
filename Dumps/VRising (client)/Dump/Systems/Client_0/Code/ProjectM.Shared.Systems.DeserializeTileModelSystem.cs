using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DeserializeTileModelSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_151631401_0;
    EntityQuery __query_151631401_1;
    
    // unmanaged system, skipped generating example queries

}
