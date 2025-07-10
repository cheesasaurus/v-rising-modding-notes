using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct LowBloodSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1780895859_0;
    EntityQuery __query_1780895859_1;
    
    // unmanaged system, skipped generating example queries

}
