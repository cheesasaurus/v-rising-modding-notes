using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ValidateItemKeyLookupSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_773907941_0;
    EntityQuery __query_773907941_1;
    
    // unmanaged system, skipped generating example queries

}
