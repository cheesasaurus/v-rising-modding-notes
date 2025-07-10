using Unity.Entities;

namespace Gameplay.Systems.Ability;


[UpdateInGroup(typeof(ProjectM.AbilityReactToCastFinishGroup))]
public struct AbilityStorePowerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _OnPreCastFinishedQuery;
    EntityQuery __query_606314456_0;
    
    // unmanaged system, skipped generating example queries

}
