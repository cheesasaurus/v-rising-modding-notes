using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SetAiMoveSpeedSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1307819114_0;
    
    // unmanaged system, skipped generating example queries

}
