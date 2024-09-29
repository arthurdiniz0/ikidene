using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	public class GetAcceleration : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat storeValue;
	}
}
