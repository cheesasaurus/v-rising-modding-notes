using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilitySequence_FetchAimDistanceFactorSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_335313476_0;
    
    // unmanaged system, skipped generating example queries

}
