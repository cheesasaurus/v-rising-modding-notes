using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_PointDestroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_107901365_0;
    
    // unmanaged system, skipped generating example queries

}
