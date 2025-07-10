using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SpawnRegionUpdateSystemPersistenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1303396302_0;
    EntityQuery __query_1303396302_1;
    
    // unmanaged system, skipped generating example queries

}
