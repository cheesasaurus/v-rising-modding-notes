using Unity.Entities;

namespace ProjectM.Community;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PlayerPresenceClientSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _PlayerPresenceQuery;
    EntityQuery _BuildModeQuery;
    EntityQuery __query_809721211_0;
    EntityQuery __query_809721211_1;
    EntityQuery __query_809721211_2;
    
    // unmanaged system, skipped generating example queries

}
