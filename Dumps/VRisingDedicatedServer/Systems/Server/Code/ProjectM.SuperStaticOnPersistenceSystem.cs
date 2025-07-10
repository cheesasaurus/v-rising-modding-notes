using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SuperStaticOnPersistenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1353801107_0;
    EntityQuery __query_1353801107_1;
    
    // unmanaged system, skipped generating example queries

}
