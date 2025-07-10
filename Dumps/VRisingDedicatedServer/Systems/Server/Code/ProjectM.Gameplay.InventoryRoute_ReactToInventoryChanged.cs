using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRoute_ReactToInventoryChanged : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2048370824_0;
    
    // unmanaged system, skipped generating example queries

}
