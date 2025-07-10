using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateBefore(typeof(ProjectM.StackModifierSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class MultiplyAbsorbCapByUnitStatsSystem : SystemBase
{
    EntityQuery __query_833794380_0;
    EntityQuery __query_833794380_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_833794380_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.AbsorbBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MultiplyAbsorbCapBySpellPower>(),
                ComponentType.ReadOnly<ProjectM.IncreaseAbsorbCapByMaxHealth>(),
                ComponentType.ReadOnly<ProjectM.SiegeWeaponAbsorbCapByServerSettings>(),
            },
        });
        
        __query_833794380_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.AbsorbBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MultiplyAbsorbCapBySpellPower>(),
                ComponentType.ReadOnly<ProjectM.IncreaseAbsorbCapByMaxHealth>(),
                ComponentType.ReadOnly<ProjectM.SiegeWeaponAbsorbCapByServerSettings>(),
            },
        });
        
    }
    

}
