using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
public struct DisableTileModelFlagsBuff_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_278710686_0;
    EntityQuery __query_278710686_1;
    
    // unmanaged system, skipped generating example queries

}
