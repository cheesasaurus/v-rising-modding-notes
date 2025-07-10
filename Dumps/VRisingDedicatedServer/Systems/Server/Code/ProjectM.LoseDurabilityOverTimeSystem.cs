using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.DurabilitySystem))]
public struct LoseDurabilityOverTimeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_517638834_0;
    EntityQuery __query_517638834_1;
    
    // unmanaged system, skipped generating example queries

}
