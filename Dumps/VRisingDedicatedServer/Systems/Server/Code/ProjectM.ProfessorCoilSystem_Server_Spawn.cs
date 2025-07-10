using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
public class ProfessorCoilSystem_Server_Spawn : SystemBase
{
    EntityQuery _ManagerSpawnQuery;
    EntityQuery _CoilEventSpawnTagQuery;
    EntityQuery _CoilQuery;
    EntityQuery _CoilManagerQuery;
    EntityQuery _BeamQuery;
    EntityQuery __query_1076403753_0;
    EntityQuery __query_1076403753_1;
    EntityQuery __query_1076403753_2;
    EntityQuery __query_1076403753_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ManagerSpawnQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.ProfessorCoilElement>(),
                ComponentType.ReadWrite<ProjectM.ProfessorCoilPairElement>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        _CoilEventSpawnTagQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProfessorCoilEvent_SpawnTag>(),
            },
        });
        
        _CoilQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProfessorCoil>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        _CoilManagerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.ProfessorCoilElement>(),
            },
        });
        
        _BeamQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProfessorCoilBeam_State_Server>(),
            },
        });
        
        __query_1076403753_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.ProfessorCoilElement>(),
                ComponentType.ReadWrite<ProjectM.ProfessorCoilPairElement>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1076403753_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ProfessorCoilEvent>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.ProfessorCoilEvent_SpawnTag>(),
            },
        });
        
        __query_1076403753_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ProfessorCoilEvent>(),
                ComponentType.ReadOnly<ProjectM.ProfessorCoilEvent_Random>(),
                ComponentType.ReadWrite<ProjectM.ProfessorCoilPairElement>(),
                ComponentType.ReadOnly<ProjectM.ProfessorCoilEvent_SpawnTag>(),
            },
        });
        
        __query_1076403753_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ProfessorCoilEvent_PredefinedSequence>(),
                ComponentType.ReadWrite<ProjectM.ProfessorCoilPairElement>(),
                ComponentType.ReadOnly<ProjectM.ProfessorCoilEvent_SpawnTag>(),
            },
        });
        
    }
    

}
