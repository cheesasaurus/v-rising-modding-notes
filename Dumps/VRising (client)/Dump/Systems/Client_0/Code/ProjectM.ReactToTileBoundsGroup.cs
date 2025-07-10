using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[UpdateAfter(typeof(ProjectM.ReactToTilePositionGroup))]
public class ReactToTileBoundsGroup : ComponentSystemGroup
{

}
