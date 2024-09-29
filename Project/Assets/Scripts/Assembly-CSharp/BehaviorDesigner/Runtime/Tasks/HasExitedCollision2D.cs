using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class HasExitedCollision2D : Conditional
	{
		public SharedString tag;
		public SharedGameObject collidedGameObject;
	}
}
