using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Hybrid.HybridModelSystem))]
[UpdateAfter(typeof(ProjectM.GlobalCritterSpawnManager))]
public struct CritterGroupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CritterGroupQuery;
    EntityQuery _CritterDataBufferQuery;
    EntityQuery _PlayerPosQuery;
    EntityQuery _NewSpawnsQuery;
    EntityQuery _RemoveSpawnsQuery;
    EntityQuery __query_1018376726_0;
    EntityQuery __query_1018376726_1;
    EntityQuery __query_1018376726_2;
    EntityQuery __query_1018376726_3;
    EntityQuery __query_1018376726_4;
    EntityQuery __query_1018376726_5;
    
    // unmanaged system, skipped generating example queries

}
