using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class SetMass : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat mass;
	}
}
