using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class GetComponent : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString type;
		public SharedObject storeValue;
	}
}
