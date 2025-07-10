using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.ReactToEquipmentChangedEventGroup))]
public struct DurabilitySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LooseDurabilityOverTimeQuery;
    EntityQuery _DurabilityQuery;
    EntityQuery __query_575196691_0;
    EntityQuery __query_575196691_1;
    EntityQuery __query_575196691_2;
    
    // unmanaged system, skipped generating example queries

}
