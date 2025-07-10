using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
public struct AiMoveSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AiMoveQuery;
    EntityQuery _UpdateQuery;
    EntityQuery _WriteInterpolationDataQuery_Baseline;
    EntityQuery _WriteInterpolationDataQuery_IdleInteractors;
    EntityQuery _ServerPopPathBufferJobQuery;
    EntityQuery _ServerCopyPathBufferToAiMoveJobQuery;
    EntityQuery _UpdateCircleDirAndDistance_OnCastQuery;
    EntityQuery _UpdateCircleDirAndDistance_EveryFrameQuery;
    EntityQuery _UpdateSeekDistanceQuery;
    EntityQuery __query_1334111847_0;
    EntityQuery __query_1334111847_1;
    EntityQuery __query_1334111847_2;
    EntityQuery __query_1334111847_3;
    EntityQuery __query_1334111847_4;
    EntityQuery __query_1334111847_5;
    EntityQuery __query_1334111847_6;
    EntityQuery __query_1334111847_7;
    EntityQuery __query_1334111847_8;
    EntityQuery __query_1334111847_9;
    
    // unmanaged system, skipped generating example queries

}
