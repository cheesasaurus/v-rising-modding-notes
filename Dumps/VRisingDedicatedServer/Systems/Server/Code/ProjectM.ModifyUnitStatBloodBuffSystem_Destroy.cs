using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyUnitStatBloodBuffSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_998822571_0;
    EntityQuery __query_998822571_1;
    
    // unmanaged system, skipped generating example queries

}
