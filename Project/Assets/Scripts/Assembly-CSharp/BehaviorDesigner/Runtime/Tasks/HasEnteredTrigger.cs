using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class HasEnteredTrigger : Conditional
	{
		public SharedString tag;
		public SharedGameObject otherGameObject;
	}
}
