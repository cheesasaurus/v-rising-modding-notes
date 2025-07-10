using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SceneLoadSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _WaitForLoadQuery;
    EntityQuery __query_222844864_0;
    
    // unmanaged system, skipped generating example queries

}
