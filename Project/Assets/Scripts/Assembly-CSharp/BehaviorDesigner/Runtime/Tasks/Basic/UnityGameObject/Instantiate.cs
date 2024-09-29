using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class Instantiate : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 position;
		public SharedQuaternion rotation;
		public SharedGameObject storeResult;
	}
}
