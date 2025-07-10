using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
[UpdateBefore(typeof(ProjectM.RemoveJewelChangedSystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public class OnJewelEquippedSystem_Server : ProjectM.OnJewelEquippedSystemBase
{
    EntityQuery __query_1105055107_0;
    EntityQuery __query_1105055107_1;
    EntityQuery __query_1105055107_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1105055107_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.JewelChanged>(),
                ComponentType.ReadOnly<ProjectM.Shared.SpellModArithmeticModifiable>(),
            },
        });
        
        __query_1105055107_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.LegendaryItemChangedEvent>(),
            },
        });
        
        __query_1105055107_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.JewelChanged>(),
                ComponentType.ReadOnly<ProjectM.SpellModAbilityGroupCharges>(),
                ComponentType.ReadWrite<ProjectM.AbilityChargesState>(),
                ComponentType.ReadWrite<ProjectM.AbilityChargesData>(),
            },
        });
        
    }
    

}
