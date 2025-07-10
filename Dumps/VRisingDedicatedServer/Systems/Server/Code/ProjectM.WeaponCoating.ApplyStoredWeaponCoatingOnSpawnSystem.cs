using Unity.Entities;

namespace ProjectM.WeaponCoating;


[UpdateInGroup(typeof(ProjectM.SpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ApplyStoredWeaponCoatingOnSpawnSystem : SystemBase
{
    EntityQuery __query_1145599276_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1145599276_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.AbilityOwner>(),
                ComponentType.ReadOnly<ProjectM.WeaponCoating.ApplyStoredWeaponCoatingOnSpawn>(),
            },
        });
        
    }
    

}
