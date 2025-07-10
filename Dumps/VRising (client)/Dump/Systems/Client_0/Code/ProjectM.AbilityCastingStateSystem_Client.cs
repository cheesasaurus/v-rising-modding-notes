using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactDuringCastGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilityCastingStateSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_335313328_0;
    EntityQuery __query_335313328_1;
    EntityQuery __query_335313328_2;
    
    // unmanaged system, skipped generating example queries

}
