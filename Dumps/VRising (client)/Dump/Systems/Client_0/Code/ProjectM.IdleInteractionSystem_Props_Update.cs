using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_Props_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_107901393_0;
    EntityQuery __query_107901393_1;
    
    // unmanaged system, skipped generating example queries

}
