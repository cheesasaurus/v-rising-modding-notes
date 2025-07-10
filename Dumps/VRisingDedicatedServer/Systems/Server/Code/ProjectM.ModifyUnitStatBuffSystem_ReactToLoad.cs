using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[UpdateAfter(typeof(Gameplay.Systems.VampireAttributeSystem_ReactToLoad))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyUnitStatBuffSystem_ReactToLoad : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_35557707_0;
    EntityQuery __query_35557707_1;
    
    // unmanaged system, skipped generating example queries

}
