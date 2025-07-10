using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct StablesSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1751579380_0;
    
    // unmanaged system, skipped generating example queries

}
