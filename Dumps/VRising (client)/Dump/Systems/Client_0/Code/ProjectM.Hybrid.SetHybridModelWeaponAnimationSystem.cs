using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.SetHybridModelLocomotionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetHybridModelWeaponAnimationSystem : SystemBase
{
    EntityQuery __query_1866984345_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1866984345_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadOnly<ProjectM.HybridCurrentEquipment>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelWeaponAnimationComponent>(),
            },
        });
        
    }
    

}
