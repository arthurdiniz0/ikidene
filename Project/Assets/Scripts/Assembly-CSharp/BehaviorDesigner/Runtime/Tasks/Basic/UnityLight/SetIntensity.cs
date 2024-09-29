using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class SetIntensity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat intensity;
	}
}
