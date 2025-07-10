using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelVBloodFlagPersistenceLoadedSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_448354740_0;
    EntityQuery __query_448354740_1;
    EntityQuery __query_448354740_2;
    
    // unmanaged system, skipped generating example queries

}
