using Unity.Entities;

namespace ProjectM.Pathfinding;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WorldRoadGraphSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _WorldSetupQuery;
    EntityQuery __query_1770262870_0;
    
    // unmanaged system, skipped generating example queries

}
