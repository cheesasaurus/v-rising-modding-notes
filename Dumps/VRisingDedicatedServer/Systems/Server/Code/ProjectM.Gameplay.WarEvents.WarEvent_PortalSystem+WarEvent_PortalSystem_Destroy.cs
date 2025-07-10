using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WarEvent_PortalSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _WarEvent_ActiveGateQuery;
    EntityQuery _WarEvent_ActiveUnitQuery;
    EntityQuery _WarEvent_ChildReferenceQuery;
    EntityQuery __query_1313273794_0;
    EntityQuery __query_1313273794_1;
    EntityQuery __query_1313273794_2;
    EntityQuery __query_1313273794_3;
    
    // unmanaged system, skipped generating example queries

}
