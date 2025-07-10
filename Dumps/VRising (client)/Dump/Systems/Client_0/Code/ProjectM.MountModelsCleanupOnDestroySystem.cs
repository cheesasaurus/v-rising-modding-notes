using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MountModelsCleanupOnDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1925403234_0;
    EntityQuery __query_1925403234_1;
    
    // unmanaged system, skipped generating example queries

}
