using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AiMoveSystem_Client_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _NonMountQuery;
    EntityQuery _MountQuery;
    EntityQuery __query_1334111571_0;
    EntityQuery __query_1334111571_1;
    EntityQuery __query_1334111571_2;
    EntityQuery __query_1334111571_3;
    
    // unmanaged system, skipped generating example queries

}
