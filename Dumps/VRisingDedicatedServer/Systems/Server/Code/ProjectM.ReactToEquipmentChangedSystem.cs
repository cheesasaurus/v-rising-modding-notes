using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToEquipmentChangedEventGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ReactToEquipmentChangedSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_32297106_0;
    
    // unmanaged system, skipped generating example queries

}
