using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PrisonSystem_ReactToDead : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1527516140_0;
    
    // unmanaged system, skipped generating example queries

}
