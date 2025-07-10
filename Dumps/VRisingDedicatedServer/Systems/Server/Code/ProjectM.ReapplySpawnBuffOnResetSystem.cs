using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ReapplySpawnBuffOnResetSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1175922345_0;
    EntityQuery __query_1175922345_1;
    EntityQuery __query_1175922345_2;
    
    // unmanaged system, skipped generating example queries

}
