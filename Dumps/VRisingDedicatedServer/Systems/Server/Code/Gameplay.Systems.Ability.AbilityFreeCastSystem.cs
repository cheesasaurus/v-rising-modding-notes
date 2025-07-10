using Unity.Entities;

namespace Gameplay.Systems.Ability;


[UpdateInGroup(typeof(ProjectM.AbilityReactToCastFinishGroup))]
public struct AbilityFreeCastSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _OnPreCastFinishedQuery;
    EntityQuery __query_558027214_0;
    EntityQuery __query_558027214_1;
    EntityQuery __query_558027214_2;
    
    // unmanaged system, skipped generating example queries

}
