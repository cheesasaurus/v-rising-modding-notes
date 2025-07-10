using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_DestroyInteractionsOnLoad : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_107901557_0;
    
    // unmanaged system, skipped generating example queries

}
