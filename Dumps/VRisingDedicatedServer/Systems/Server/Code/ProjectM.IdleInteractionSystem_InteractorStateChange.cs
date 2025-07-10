using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_InteractorStateChange : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_107901263_0;
    EntityQuery __query_107901263_1;
    EntityQuery __query_107901263_2;
    
    // unmanaged system, skipped generating example queries

}
