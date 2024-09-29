using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class SetFloatParameter : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString paramaterName;
		public SharedFloat floatValue;
		public bool setOnce;
	}
}
