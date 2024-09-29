using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityBoxCollider2D
{
	public class SetSize : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector2 size;
	}
}
