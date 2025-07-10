using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SuperStaticDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1353801159_0;
    EntityQuery __query_1353801159_1;
    
    // unmanaged system, skipped generating example queries

}
