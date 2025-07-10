using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.GetHybridDataGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct GetHybridModelLocomotionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1676039131_0;
    EntityQuery __query_1676039131_1;
    EntityQuery __query_1676039131_2;
    EntityQuery __query_1676039131_3;
    EntityQuery __query_1676039131_4;
    
    // unmanaged system, skipped generating example queries

}
