using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.PlayCommandSystemGroup))]
[UpdateAfter(typeof(ProjectM.CreateInputCommandsSystem))]
public struct PlayCommandsSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1019327463_0;
    EntityQuery __query_1019327463_1;
    EntityQuery __query_1019327463_2;
    EntityQuery __query_1019327463_3;
    EntityQuery __query_1019327463_4;
    
    // unmanaged system, skipped generating example queries

}
