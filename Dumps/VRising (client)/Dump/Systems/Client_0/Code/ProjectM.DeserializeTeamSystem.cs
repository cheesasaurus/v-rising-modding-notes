using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
public struct DeserializeTeamSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ChangedCastleHeartTeams;
    EntityQuery _ChangedCastleHeartConnections;
    EntityQuery __query_1901373249_0;
    EntityQuery __query_1901373249_1;
    EntityQuery __query_1901373249_2;
    
    // unmanaged system, skipped generating example queries

}
