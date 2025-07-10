using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AiDynamicCollisionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1334111442_0;
    EntityQuery __query_1334111442_1;
    EntityQuery __query_1334111442_2;
    
    // unmanaged system, skipped generating example queries

}
