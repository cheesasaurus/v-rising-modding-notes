using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.InputGroup))]
public class EntityControlSystem : SystemBase
{
    EntityQuery __query_201135240_0;
    EntityQuery __query_201135240_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_201135240_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
        });
        
        __query_201135240_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.InputCommandBufferElement>(),
            },
        });
        
    }
    

}
