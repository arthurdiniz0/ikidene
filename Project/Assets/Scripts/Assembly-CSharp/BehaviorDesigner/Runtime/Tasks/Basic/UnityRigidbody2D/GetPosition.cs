using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class GetPosition : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector2 storeValue;
	}
}
