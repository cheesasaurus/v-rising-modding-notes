using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct KillSystemClient : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    
    // unmanaged system, skipped generating example queries

}
