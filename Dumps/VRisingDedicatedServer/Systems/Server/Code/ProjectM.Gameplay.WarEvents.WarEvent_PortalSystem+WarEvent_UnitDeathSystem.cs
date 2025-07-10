using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WarEvent_UnitDeathSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1313273856_0;
    EntityQuery __query_1313273856_1;
    
    // unmanaged system, skipped generating example queries

}
