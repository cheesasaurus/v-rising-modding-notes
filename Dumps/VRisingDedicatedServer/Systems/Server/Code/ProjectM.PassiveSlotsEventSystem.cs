using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PassiveSlotsEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AddQuery;
    EntityQuery _RemoveQuery;
    EntityQuery __query_1453777280_0;
    EntityQuery __query_1453777280_1;
    
    // unmanaged system, skipped generating example queries

}
