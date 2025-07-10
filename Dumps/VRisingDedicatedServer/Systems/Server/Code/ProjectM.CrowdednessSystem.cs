using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CrowdednessSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_2048942089_0;
    
    // unmanaged system, skipped generating example queries

}
