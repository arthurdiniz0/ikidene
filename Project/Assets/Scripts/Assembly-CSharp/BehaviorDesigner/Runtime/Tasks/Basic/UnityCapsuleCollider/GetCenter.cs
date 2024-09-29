using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCapsuleCollider
{
	public class GetCenter : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 storeValue;
	}
}
