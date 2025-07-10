using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToUnitStatChangedEventGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitStatChangedEventCleanupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_595732768_0;
    
    // unmanaged system, skipped generating example queries

}
