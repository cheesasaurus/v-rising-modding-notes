using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DeadSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1359981139_0;
    EntityQuery __query_1359981139_1;
    EntityQuery __query_1359981139_2;
    
    // unmanaged system, skipped generating example queries

}
