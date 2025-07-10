using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct HideScenerySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DisabledSceneryObjectsQuery;
    EntityQuery _EnabledSceneryObjectsQuery;
    EntityQuery _BlockersQuery;
    EntityQuery __query_1769623891_0;
    
    // unmanaged system, skipped generating example queries

}
