using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_Props_BuffDestroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_107901524_0;
    
    // unmanaged system, skipped generating example queries

}
