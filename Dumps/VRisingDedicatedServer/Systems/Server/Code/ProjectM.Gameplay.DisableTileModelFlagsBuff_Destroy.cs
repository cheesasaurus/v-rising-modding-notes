using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
public struct DisableTileModelFlagsBuff_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_278710722_0;
    EntityQuery __query_278710722_1;
    
    // unmanaged system, skipped generating example queries

}
