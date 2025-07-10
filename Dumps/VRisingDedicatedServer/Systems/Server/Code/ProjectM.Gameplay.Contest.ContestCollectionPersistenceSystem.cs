using Unity.Entities;

namespace ProjectM.Gameplay.Contest;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestCollectionPersistenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestAreaLoadedQuery;
    EntityQuery __query_2119395430_0;
    EntityQuery __query_2119395430_1;
    
    // unmanaged system, skipped generating example queries

}
