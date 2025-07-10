using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateAfter(typeof(ProjectM.Network.PacketBookkeeperSystem))]
[UpdateAfter(typeof(ProjectM.Network.PrioritizeSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MakePacketSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ConnectedUserQuery;
    EntityQuery __query_220282346_0;
    EntityQuery __query_220282346_1;
    EntityQuery __query_220282346_2;
    EntityQuery __query_220282346_3;
    EntityQuery __query_220282346_4;
    EntityQuery __query_220282346_5;
    EntityQuery __query_220282346_6;
    EntityQuery __query_220282346_7;
    
    // unmanaged system, skipped generating example queries

}
