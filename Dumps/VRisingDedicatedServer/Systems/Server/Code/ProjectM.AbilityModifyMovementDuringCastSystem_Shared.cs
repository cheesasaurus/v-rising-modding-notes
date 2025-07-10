using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityMoveGroup))]
[UpdateAfter(typeof(ProjectM.AbilityCast_SetupStartValues_Shared))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilityModifyMovementDuringCastSystem_Shared : ISystem, ISystemCompilerGenerated
{
    EntityQuery _InterruptedQuery;
    EntityQuery _AbilityCastFinishedEventQuery;
    EntityQuery _ModifyMovementDuringCastQuery;
    EntityQuery _AbilityCastStartedEventQuery;
    EntityQuery __query_335314152_0;
    EntityQuery __query_335314152_1;
    EntityQuery __query_335314152_2;
    EntityQuery __query_335314152_3;
    EntityQuery __query_335314152_4;
    
    // unmanaged system, skipped generating example queries

}
