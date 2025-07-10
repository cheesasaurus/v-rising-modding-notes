using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
[UpdateAfter(typeof(Unity.Rendering.RegisterMaterialsAndMeshesSystem))]
public class DeformationsInPresentation : ComponentSystemGroup
{

}
