using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.GetHybridDataGroup))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct VisibilitySystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _GetHideableEntitiesQuery;
    EntityQuery __query_14898540_0;
    EntityQuery __query_14898540_1;
    EntityQuery __query_14898540_2;
    
    // unmanaged system, skipped generating example queries

}
