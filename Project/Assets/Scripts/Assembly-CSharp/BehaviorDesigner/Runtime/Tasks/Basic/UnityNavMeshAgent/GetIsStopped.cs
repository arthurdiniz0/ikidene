using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	public class GetIsStopped : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool storeValue;
	}
}
