using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SpellSchoolAbilityUnlockedChangedEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery _SpellSchoolsQuery;
    EntityQuery __query_1453777040_0;
    EntityQuery __query_1453777040_1;
    
    // unmanaged system, skipped generating example queries

}
