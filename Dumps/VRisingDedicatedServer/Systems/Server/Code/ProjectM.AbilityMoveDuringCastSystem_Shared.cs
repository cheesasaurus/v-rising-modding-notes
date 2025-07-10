using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityMoveGroup))]
[UpdateAfter(typeof(ProjectM.AbilityModifyMovementDuringCastSystem_Shared))]
[UpdateAfter(typeof(ProjectM.AbilityCast_SetupStartValues_Shared))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilityMoveDuringCastSystem_Shared : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_335314355_0;
    EntityQuery __query_335314355_1;
    EntityQuery __query_335314355_2;
    EntityQuery __query_335314355_3;
    
    // unmanaged system, skipped generating example queries

}
