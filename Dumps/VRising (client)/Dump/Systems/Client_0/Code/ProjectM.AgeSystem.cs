using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AgeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DisabledQuery;
    EntityQuery _EnabledQuery;
    EntityQuery __query_1071429994_0;
    EntityQuery __query_1071429994_1;
    
    // unmanaged system, skipped generating example queries

}
