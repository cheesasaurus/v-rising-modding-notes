using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeSpawnGroup))]
public struct MegaStaticInstantiationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _NewInstantiatedEntitiesQuery;
    EntityQuery __query_287427333_0;
    EntityQuery __query_287427333_1;
    EntityQuery __query_287427333_2;
    
    // unmanaged system, skipped generating example queries

}
