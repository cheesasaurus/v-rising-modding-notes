using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TakeDamageInSunSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TakeDamageInSunQuery;
    EntityQuery __query_1202092313_0;
    EntityQuery __query_1202092313_1;
    EntityQuery __query_1202092313_2;
    EntityQuery __query_1202092313_3;
    
    // unmanaged system, skipped generating example queries

}
