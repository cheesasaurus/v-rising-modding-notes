using Unity.Entities;

namespace Unity.Scenes;


[UpdateInGroup(typeof(Unity.Scenes.SceneSystemGroup))]
[UpdateBefore(typeof(Unity.Scenes.ResolveSceneReferenceSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WeakAssetReferenceLoadingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1823237996_0;
    EntityQuery __query_1823237996_1;
    
    // unmanaged system, skipped generating example queries

}
