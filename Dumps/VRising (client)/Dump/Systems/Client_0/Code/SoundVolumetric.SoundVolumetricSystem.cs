using Unity.Entities;

namespace SoundVolumetric;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
[UpdateBefore(typeof(ProjectM.Audio.StudioEventSystem))]
public struct SoundVolumetricSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1114677805_0;
    EntityQuery __query_1114677805_1;
    EntityQuery __query_1114677805_2;
    EntityQuery __query_1114677805_3;
    
    // unmanaged system, skipped generating example queries

}
