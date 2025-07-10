using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ClearAnimationStatesSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1838254586_0;
    
    // unmanaged system, skipped generating example queries

}
