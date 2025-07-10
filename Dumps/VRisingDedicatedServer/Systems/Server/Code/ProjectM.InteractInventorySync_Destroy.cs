using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InteractInventorySync_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_710171307_0;
    
    // unmanaged system, skipped generating example queries

}
