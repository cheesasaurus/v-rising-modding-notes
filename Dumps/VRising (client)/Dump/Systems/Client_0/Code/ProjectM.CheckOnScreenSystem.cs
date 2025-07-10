using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.CameraPresentationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CheckOnScreenSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EntityQuery;
    EntityQuery __query_505981384_0;
    
    // unmanaged system, skipped generating example queries

}
