using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class SetSpotAngle : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat spotAngle;
	}
}
