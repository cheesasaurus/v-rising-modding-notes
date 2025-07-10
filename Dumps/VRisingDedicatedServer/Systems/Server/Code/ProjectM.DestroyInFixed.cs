using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(FixedStepSimulationSystemGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyInFixed : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_917392815_0;
    
    // unmanaged system, skipped generating example queries

}
