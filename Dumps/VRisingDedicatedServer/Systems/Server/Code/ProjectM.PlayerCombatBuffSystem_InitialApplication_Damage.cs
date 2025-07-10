using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.StatChangeSystem))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.StatChangeMutationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PlayerCombatBuffSystem_InitialApplication_Damage : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_928948779_0;
    EntityQuery __query_928948779_1;
    EntityQuery __query_928948779_2;
    EntityQuery __query_928948779_3;
    EntityQuery __query_928948779_4;
    
    // unmanaged system, skipped generating example queries

}
