using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyBehaviourBuffSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_168487809_0;
    EntityQuery __query_168487809_1;
    
    // unmanaged system, skipped generating example queries

}
