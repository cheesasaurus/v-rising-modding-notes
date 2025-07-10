using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UserHeartCountOnLoadedSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_107222492_0;
    EntityQuery __query_107222492_1;
    
    // unmanaged system, skipped generating example queries

}
