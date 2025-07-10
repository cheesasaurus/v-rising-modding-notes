using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyWhenNoCharacterNearbyAfterDurationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1435697461_0;
    EntityQuery __query_1435697461_1;
    
    // unmanaged system, skipped generating example queries

}
