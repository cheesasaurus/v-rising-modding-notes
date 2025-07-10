using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
[UpdateAfter(typeof(ProjectM.DestroyBarrier))]
public class DestroyGroup : ComponentSystemGroup
{
    EntityQuery _DestroyedThisUpdate;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyedThisUpdate = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
