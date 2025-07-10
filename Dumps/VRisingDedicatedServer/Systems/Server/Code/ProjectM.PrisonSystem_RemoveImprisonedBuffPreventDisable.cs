using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PrisonSystem_RemoveImprisonedBuffPreventDisable : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_40310094_0;
    EntityQuery __query_40310094_1;
    
    // unmanaged system, skipped generating example queries

}
