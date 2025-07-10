using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MoveGroup))]
[UpdateAfter(typeof(ProjectM.SpellMovementSystem_Update))]
[RequireMatchingQueriesForUpdateAttribute]
public class ProjectileSystem : SystemBase
{
    EntityQuery __query_1963200583_0;
    EntityQuery __query_1963200583_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1963200583_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ProjectileSnapToHeight>(),
                ComponentType.ReadWrite<ProjectM.LastTranslation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1963200583_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
