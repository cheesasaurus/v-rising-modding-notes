using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_Props_BuffSpawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_107901484_0;
    EntityQuery __query_107901484_1;
    
    // unmanaged system, skipped generating example queries

}
