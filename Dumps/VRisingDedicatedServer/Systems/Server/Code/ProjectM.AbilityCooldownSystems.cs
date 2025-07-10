using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactDuringCastGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AbilityCooldownSystems : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1605426227_0;
    EntityQuery __query_1605426227_1;
    EntityQuery __query_1605426227_2;
    
    // unmanaged system, skipped generating example queries

}
