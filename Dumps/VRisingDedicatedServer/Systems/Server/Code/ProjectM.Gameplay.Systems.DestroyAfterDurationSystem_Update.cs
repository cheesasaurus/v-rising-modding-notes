using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyAfterDurationSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1807983397_0;
    EntityQuery __query_1807983397_1;
    EntityQuery __query_1807983397_2;
    EntityQuery __query_1807983397_3;
    EntityQuery __query_1807983397_4;
    
    // unmanaged system, skipped generating example queries

}
