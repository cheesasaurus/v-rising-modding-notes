using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.RemapAbilitySlotsForGamepadSystem))]
public class TriggerRemapAbilitySlotsForGamepadSystem : SystemBase
{

}
