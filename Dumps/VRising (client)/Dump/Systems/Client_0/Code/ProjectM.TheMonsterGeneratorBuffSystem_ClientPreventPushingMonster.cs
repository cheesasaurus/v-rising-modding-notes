using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TheMonsterGeneratorBuffSystem_ClientPreventPushingMonster : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_666345522_0;
    
    // unmanaged system, skipped generating example queries

}
