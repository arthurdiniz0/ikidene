using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class HasEnteredCollision2D : Conditional
	{
		public SharedString tag;
		public SharedGameObject collidedGameObject;
	}
}
