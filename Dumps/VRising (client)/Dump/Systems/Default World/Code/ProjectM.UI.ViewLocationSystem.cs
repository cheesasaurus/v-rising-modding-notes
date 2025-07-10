using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ViewLocationSystem : SystemBase
{

}
