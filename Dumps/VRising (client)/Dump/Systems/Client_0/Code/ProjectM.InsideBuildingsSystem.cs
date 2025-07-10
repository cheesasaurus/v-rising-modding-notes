using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InsideBuildingsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_904963949_0;
    
    // unmanaged system, skipped generating example queries

}
