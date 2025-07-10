using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RemoveServerSCTs : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_451949952_0;
    EntityQuery __query_451949952_1;
    
    // unmanaged system, skipped generating example queries

}
