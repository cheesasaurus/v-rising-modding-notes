using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CreateGameplayEventOnLeaveCliffSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_607009184_0;
    EntityQuery __query_607009184_1;
    EntityQuery __query_607009184_2;
    EntityQuery __query_607009184_3;
    EntityQuery __query_607009184_4;
    
    // unmanaged system, skipped generating example queries

}
