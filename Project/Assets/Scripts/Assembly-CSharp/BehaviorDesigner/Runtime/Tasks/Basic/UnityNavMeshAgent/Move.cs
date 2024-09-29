using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	public class Move : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 offset;
	}
}
