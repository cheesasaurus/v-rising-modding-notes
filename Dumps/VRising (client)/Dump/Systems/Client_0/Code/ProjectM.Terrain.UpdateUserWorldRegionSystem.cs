using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdateUserWorldRegionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MapRegionsQuery;
    EntityQuery _UserQuery;
    EntityQuery _CurrentWorldRegionChangedEventQuery;
    EntityQuery __query_1979656140_0;
    EntityQuery __query_1979656140_1;
    EntityQuery __query_1979656140_2;
    
    // unmanaged system, skipped generating example queries

}
