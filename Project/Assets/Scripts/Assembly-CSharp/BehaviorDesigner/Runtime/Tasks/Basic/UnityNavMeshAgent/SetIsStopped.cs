using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	public class SetIsStopped : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool isStopped;
	}
}
