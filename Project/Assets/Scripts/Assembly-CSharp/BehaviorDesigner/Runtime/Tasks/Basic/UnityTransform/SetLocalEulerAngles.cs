using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class SetLocalEulerAngles : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 localEulerAngles;
	}
}
