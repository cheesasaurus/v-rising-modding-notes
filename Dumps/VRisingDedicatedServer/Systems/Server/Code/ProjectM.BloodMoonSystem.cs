using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BloodMoonSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1969551906_0;
    
    // unmanaged system, skipped generating example queries

}
