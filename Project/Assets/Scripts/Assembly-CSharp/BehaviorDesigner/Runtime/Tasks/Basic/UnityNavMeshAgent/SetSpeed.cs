using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	public class SetSpeed : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat speed;
	}
}
