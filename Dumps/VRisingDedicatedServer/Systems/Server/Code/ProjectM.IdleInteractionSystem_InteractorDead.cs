using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_InteractorDead : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_107901304_0;
    EntityQuery __query_107901304_1;
    
    // unmanaged system, skipped generating example queries

}
