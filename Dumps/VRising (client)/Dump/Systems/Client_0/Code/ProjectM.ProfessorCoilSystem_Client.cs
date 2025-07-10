using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ProfessorCoilSystem_Client : SystemBase
{
    EntityQuery __query_1076404296_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1076404296_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProfessorCoilBeam_Client>(),
                ComponentType.ReadOnly<ProjectM.ProfessorCoilBeam_State_Shared>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
            },
        });
        
    }
    

}
