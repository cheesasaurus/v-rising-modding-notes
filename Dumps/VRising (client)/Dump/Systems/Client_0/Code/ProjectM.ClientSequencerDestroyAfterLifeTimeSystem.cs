using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ClientSequencerDestroyAfterLifeTimeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_203293457_0;
    
    // unmanaged system, skipped generating example queries

}
