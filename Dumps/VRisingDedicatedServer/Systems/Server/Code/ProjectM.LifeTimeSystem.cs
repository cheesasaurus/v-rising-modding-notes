using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct LifeTimeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1624507925_0;
    EntityQuery __query_1624507925_1;
    
    // unmanaged system, skipped generating example queries

}
