using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[UpdateAfter(typeof(ProjectM.Terrain.TerrainManager))]
public class ReactToChunkLoadedGroup : ComponentSystemGroup
{

}
