using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class HasExitedTrigger : Conditional
	{
		public SharedString tag;
		public SharedGameObject otherGameObject;
	}
}
