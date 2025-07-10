using Unity.Entities;

namespace Unity.Entities.Graphics.Extension;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
public class OcclusionCullingEntityGraphicsSystem : SystemBase
{

}
