using Unity.Entities;

[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TutorialEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CompleteTutorialEvents;
    EntityQuery _ClearTutorialEvents;
    EntityQuery __query_254751341_0;
    EntityQuery __query_254751341_1;
    
    // unmanaged system, skipped generating example queries

}
