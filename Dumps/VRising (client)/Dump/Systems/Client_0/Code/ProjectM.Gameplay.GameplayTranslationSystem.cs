using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct GameplayTranslationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_651495305_0;
    
    // unmanaged system, skipped generating example queries

}
