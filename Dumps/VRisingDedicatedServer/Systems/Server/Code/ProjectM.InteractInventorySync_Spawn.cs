using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InteractInventorySync_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_710171220_0;
    
    // unmanaged system, skipped generating example queries

}
