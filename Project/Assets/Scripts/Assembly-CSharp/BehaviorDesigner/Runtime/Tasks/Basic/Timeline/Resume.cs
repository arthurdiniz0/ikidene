using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Timeline
{
	public class Resume : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool stopWhenComplete;
	}
}
