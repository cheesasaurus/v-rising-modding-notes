using Unity.Entities;

namespace Unity.Scenes;


[UpdateInGroup(typeof(Unity.Scenes.SceneSystemGroup))]
public struct SceneSystem : ISystem, ISystemCompilerGenerated, ISystemStartStop
{
    EntityQuery _unloadSceneQuery;
    
    // unmanaged system, skipped generating example queries

}
