using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyOnMountedCollisionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_157289603_0;
    EntityQuery __query_157289603_1;
    EntityQuery __query_157289603_2;
    EntityQuery __query_157289603_3;
    
    // unmanaged system, skipped generating example queries

}
