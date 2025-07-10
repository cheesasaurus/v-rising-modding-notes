using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToEquipmentChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct EquipmentSyncSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_710171161_0;
    
    // unmanaged system, skipped generating example queries

}
