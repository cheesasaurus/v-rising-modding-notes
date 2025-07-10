using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.Network.SetupNetworkIdSystem))]
public struct MegaStaticServerSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_467135113_0;
    EntityQuery __query_467135113_1;
    
    // unmanaged system, skipped generating example queries

}
