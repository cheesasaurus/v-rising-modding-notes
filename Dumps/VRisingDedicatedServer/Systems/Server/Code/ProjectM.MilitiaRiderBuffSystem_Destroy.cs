using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MilitiaRiderBuffSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_21045714_0;
    EntityQuery __query_21045714_1;
    
    // unmanaged system, skipped generating example queries

}
