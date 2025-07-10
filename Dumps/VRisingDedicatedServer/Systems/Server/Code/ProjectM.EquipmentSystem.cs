using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToEquipmentChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct EquipmentSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1269768775_0;
    EntityQuery __query_1269768775_1;
    EntityQuery __query_1269768775_2;
    EntityQuery __query_1269768775_3;
    EntityQuery __query_1269768775_4;
    
    // unmanaged system, skipped generating example queries

}
