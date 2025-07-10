using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup))]
public class DetectJewelChangedSystem_Client : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1105054984_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.AbilitySpellModItem>(),
                ComponentType.ReadWrite<ProjectM.Shared.LastAbilitySpellModItem>(),
                ComponentType.ReadOnly<ProjectM.Shared.SpellModSetComponent>(),
                ComponentType.ReadOnly<ProjectM.AbilityStateBuffer>(),
            },
        });
        
        __query_1105054984_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.AbilitySpellModItem>(),
                ComponentType.ReadWrite<ProjectM.Shared.LastAbilitySpellModItem>(),
                ComponentType.ReadOnly<ProjectM.Shared.SpellModSetComponent>(),
                ComponentType.ReadOnly<ProjectM.AbilityStateBuffer>(),
            },
        });
        
    }
    

}
