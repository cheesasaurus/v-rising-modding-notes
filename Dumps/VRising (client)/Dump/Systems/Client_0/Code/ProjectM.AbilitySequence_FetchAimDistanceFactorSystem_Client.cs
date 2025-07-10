using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactDuringCastGroup))]
[UpdateAfter(typeof(ProjectM.AbilityCastingStateSystem_Client))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilitySequence_FetchAimDistanceFactorSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_335313533_0;
    EntityQuery __query_335313533_1;
    EntityQuery __query_335313533_2;
    
    // unmanaged system, skipped generating example queries

}
