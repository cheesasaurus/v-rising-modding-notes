using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DeleteMapMarkerSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_16518602_0;
    EntityQuery __query_16518602_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.DeleteMapMarkerEvent>(),
            },
        });
        
        __query_16518602_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.DeleteMapMarkerEvent>(),
            },
        });
        
        __query_16518602_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.MapIconData>(),
            },
        });
        
    }
    

}
