using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.DeadSequenceSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DeadSequenceDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1359981259_0;
    
    // unmanaged system, skipped generating example queries

}
