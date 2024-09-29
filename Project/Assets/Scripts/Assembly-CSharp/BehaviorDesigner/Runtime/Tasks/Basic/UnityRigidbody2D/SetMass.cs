using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class SetMass : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat mass;
	}
}
