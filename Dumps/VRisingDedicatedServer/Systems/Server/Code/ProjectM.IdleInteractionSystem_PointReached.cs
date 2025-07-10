using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_PointReached : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_107901181_0;
    EntityQuery __query_107901181_1;
    EntityQuery __query_107901181_2;
    
    // unmanaged system, skipped generating example queries

}
