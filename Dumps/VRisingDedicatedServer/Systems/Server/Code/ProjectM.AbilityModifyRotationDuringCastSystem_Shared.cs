using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityMoveGroup))]
[UpdateAfter(typeof(ProjectM.AbilityCast_SetupStartValues_Shared))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilityModifyRotationDuringCastSystem_Shared : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AbilityCastStartedEvents;
    EntityQuery _AbilityPreCastFinishedEvents;
    EntityQuery _ModifyRotations;
    EntityQuery _AbilityPreCastEndedEvents;
    EntityQuery _AbilityPostCastEndedEvents;
    EntityQuery __query_335313613_0;
    EntityQuery __query_335313613_1;
    EntityQuery __query_335313613_2;
    EntityQuery __query_335313613_3;
    EntityQuery __query_335313613_4;
    EntityQuery __query_335313613_5;
    EntityQuery __query_335313613_6;
    EntityQuery __query_335313613_7;
    EntityQuery __query_335313613_8;
    EntityQuery __query_335313613_9;
    EntityQuery __query_335313613_10;
    EntityQuery __query_335313613_11;
    
    // unmanaged system, skipped generating example queries

}
