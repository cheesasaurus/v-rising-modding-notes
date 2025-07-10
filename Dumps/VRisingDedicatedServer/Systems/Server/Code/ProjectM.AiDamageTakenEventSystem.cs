using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.StatChangeSystem))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.StatChangeMutationSystem))]
public struct AiDamageTakenEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AiDamageTakenEventQuery;
    EntityQuery _StatEventQuery;
    EntityQuery __query_5672616_0;
    EntityQuery __query_5672616_1;
    
    // unmanaged system, skipped generating example queries

}
