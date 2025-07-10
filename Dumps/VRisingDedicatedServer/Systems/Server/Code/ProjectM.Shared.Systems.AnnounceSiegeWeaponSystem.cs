using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AnnounceSiegeWeaponSystem : SystemBase
{
    EntityQuery _AnnounceSiegeWeaponQuery;
    EntityQuery __query_2095376349_0;
    EntityQuery __query_2095376349_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AnnounceSiegeWeaponQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AnnounceSiegeWeapon>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_2095376349_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_2095376349_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
