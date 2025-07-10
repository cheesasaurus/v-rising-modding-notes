using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public class ProjectileSystem_Spawn_Client : SystemBase
{
    EntityQuery _MainQuery1;
    EntityQuery _MainQuery2;
    EntityQuery __query_1963200539_0;
    EntityQuery __query_1963200539_1;
    EntityQuery __query_1963200539_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpellMovement>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        _MainQuery2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ProjectileSnapToHeight>(),
                ComponentType.ReadOnly<ProjectM.SpellMovement>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1963200539_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpellMovement>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1963200539_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ProjectileSnapToHeight>(),
                ComponentType.ReadOnly<ProjectM.SpellMovement>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1963200539_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
