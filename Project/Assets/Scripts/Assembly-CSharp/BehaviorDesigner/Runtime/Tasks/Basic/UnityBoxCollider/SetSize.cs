using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityBoxCollider
{
	public class SetSize : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 size;
	}
}
