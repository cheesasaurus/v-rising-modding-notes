using Unity.Entities;

namespace Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct VampireAttributeSystem_ReactToLoad : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_2123997347_0;
    EntityQuery __query_2123997347_1;
    EntityQuery __query_2123997347_2;
    
    // unmanaged system, skipped generating example queries

}
