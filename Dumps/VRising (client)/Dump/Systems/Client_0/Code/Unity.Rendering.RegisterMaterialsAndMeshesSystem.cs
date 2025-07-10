using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
[CreateAfter(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
public class RegisterMaterialsAndMeshesSystem : SystemBase
{

}
