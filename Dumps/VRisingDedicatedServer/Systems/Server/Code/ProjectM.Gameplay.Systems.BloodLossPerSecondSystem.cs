using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BloodLossPerSecondSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_865506327_0;
    EntityQuery __query_865506327_1;
    EntityQuery __query_865506327_2;
    
    // unmanaged system, skipped generating example queries

}
