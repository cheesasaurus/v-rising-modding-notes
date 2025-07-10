using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(Unity.Transforms.TransformSystemGroup))]
[UpdateAfter(typeof(ProjectM.StaticHierarchySystem))]
[UpdateAfter(typeof(Unity.Transforms.LocalToWorldSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class RotateAroundAxisSystem : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RotateAroundAxis>(),
                ComponentType.ReadWrite<Unity.Transforms.LocalToWorld>(),
            },
        });
        
    }
    

}
