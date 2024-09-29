using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class HasExitedCollision : Conditional
	{
		public SharedString tag;
		public SharedGameObject collidedGameObject;
	}
}
