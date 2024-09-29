using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	public class SetAngularSpeed : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat angularSpeed;
	}
}
