using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
public struct MegaStaticServerDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_467135235_0;
    EntityQuery __query_467135235_1;
    EntityQuery __query_467135235_2;
    
    // unmanaged system, skipped generating example queries

}
