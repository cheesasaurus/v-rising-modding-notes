using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaDeformationSystemGroup))]
[CreateAfter(typeof(Unity.Rendering.RegisterMaterialsAndMeshesSystem))]
public struct SkinnedMeshPreparationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_881941802_0;
    EntityQuery __query_881941802_1;
    EntityQuery __query_881941802_2;
    EntityQuery __query_881941802_3;
    EntityQuery __query_881941802_4;
    
    // unmanaged system, skipped generating example queries

}
