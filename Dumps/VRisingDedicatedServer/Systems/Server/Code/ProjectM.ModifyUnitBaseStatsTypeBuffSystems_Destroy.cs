using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyUnitBaseStatsTypeBuffSystems_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_294634982_0;
    EntityQuery __query_294634982_1;
    
    // unmanaged system, skipped generating example queries

}
