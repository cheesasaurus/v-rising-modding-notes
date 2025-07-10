using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityMoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilityCast_SetupStartValues_Shared : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_335313246_0;
    EntityQuery __query_335313246_1;
    
    // unmanaged system, skipped generating example queries

}
