using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class AddTorque : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat torque;
	}
}
