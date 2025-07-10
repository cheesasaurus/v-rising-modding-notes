using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitMountBuffShareSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1987576697_0;
    
    // unmanaged system, skipped generating example queries

}
