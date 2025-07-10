using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct EquipmentSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EquipQuery;
    EntityQuery _UnEquipQuery;
    EntityQuery __query_1577456886_0;
    EntityQuery __query_1577456886_1;
    
    // unmanaged system, skipped generating example queries

}
