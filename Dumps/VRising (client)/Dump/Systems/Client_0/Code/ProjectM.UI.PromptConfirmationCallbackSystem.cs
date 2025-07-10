using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class PromptConfirmationCallbackSystem : SystemBase
{
    EntityQuery __query_729321481_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_729321481_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MiscLocalizationKeysSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
