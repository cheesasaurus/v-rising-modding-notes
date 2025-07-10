using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.ProgressAchievementSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RepairProgressEnterAreaAchievements : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1295658073_0;
    
    // unmanaged system, skipped generating example queries

}
