using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestPersistenceLoaded_System : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestQuery;
    EntityQuery _FlagBuffQuery;
    EntityQuery __query_801697325_0;
    EntityQuery __query_801697325_1;
    
    // unmanaged system, skipped generating example queries

}
