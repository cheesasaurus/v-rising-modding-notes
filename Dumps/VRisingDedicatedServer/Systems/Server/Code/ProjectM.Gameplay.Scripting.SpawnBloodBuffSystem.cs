using Unity.Entities;

namespace ProjectM.Gameplay.Scripting;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
public struct SpawnBloodBuffSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _BloodBuffQuery;
    EntityQuery _BloodBuffLastStrikeQuery;
    EntityQuery _BloodBuffBloodMendBonusQuery;
    EntityQuery __query_2145507943_0;
    EntityQuery __query_2145507943_1;
    EntityQuery __query_2145507943_2;
    
    // unmanaged system, skipped generating example queries

}
