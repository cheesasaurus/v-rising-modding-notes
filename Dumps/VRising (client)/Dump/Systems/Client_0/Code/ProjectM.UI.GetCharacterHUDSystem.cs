using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.CharacterHUDGroup))]
public class GetCharacterHUDSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery _AbsorbBuffQuery;
    EntityQuery _CreateEventOnHealthChangeAmountQuery;
    EntityQuery __query_1404660283_0;
    EntityQuery __query_1404660283_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CheckOnScreen>(),
                ComponentType.ReadWrite<ProjectM.UI.HealthBarHUD>(),
                ComponentType.ReadWrite<ProjectM.CharacterHUD>(),
                ComponentType.ReadOnly<ProjectM.Health>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        _AbsorbBuffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.AbsorbBuff>(),
            },
        });
        
        _CreateEventOnHealthChangeAmountQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.CreateEventOnHealthChangeAmount>(),
            },
        });
        
        __query_1404660283_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<ProjectM.CheckOnScreen>(),
                ComponentType.ReadWrite<ProjectM.CharacterHUD>(),
            },
        });
        
        __query_1404660283_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.HideTargetHUD>(),
            },
        });
        
    }
    

}
