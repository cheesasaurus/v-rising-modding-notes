using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SuperStaticSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1353801129_0;
    EntityQuery __query_1353801129_1;
    
    // unmanaged system, skipped generating example queries

}
