using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BlockDraculaWarpRiftSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DraculaSpawnerQuery;
    EntityQuery __query_1480550021_0;
    EntityQuery __query_1480550021_1;
    EntityQuery __query_1480550021_2;
    
    // unmanaged system, skipped generating example queries

}
