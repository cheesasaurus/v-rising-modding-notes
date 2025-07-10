using Unity.Entities;

[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class VoiceOverlaySystem : SystemBase
{
    EntityQuery __query_571472858_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_571472858_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<ProjectM.CharacterVoiceActivity>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
