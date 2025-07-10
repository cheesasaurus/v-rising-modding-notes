using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateAfter(typeof(ProjectM.AggroSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RepairInverseAggroSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1017882745_0;
    
    // unmanaged system, skipped generating example queries

}
