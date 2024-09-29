using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class HasEnteredCollision : Conditional
	{
		public SharedString tag;
		public SharedGameObject collidedGameObject;
	}
}
