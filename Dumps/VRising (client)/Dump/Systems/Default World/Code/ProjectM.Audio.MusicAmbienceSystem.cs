using Unity.Entities;

namespace ProjectM.Audio;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
[UpdateBefore(typeof(ProjectM.Audio.StudioManagerSystem))]
public class MusicAmbienceSystem : SystemBase
{

}
