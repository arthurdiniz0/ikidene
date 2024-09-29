using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRenderer
{
	public class SetMaterial : Action
	{
		public SharedGameObject targetGameObject;
		public SharedMaterial material;
	}
}
