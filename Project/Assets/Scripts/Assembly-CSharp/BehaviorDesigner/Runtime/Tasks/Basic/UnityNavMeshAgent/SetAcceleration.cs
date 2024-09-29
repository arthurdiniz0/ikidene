using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	public class SetAcceleration : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat acceleration;
	}
}
