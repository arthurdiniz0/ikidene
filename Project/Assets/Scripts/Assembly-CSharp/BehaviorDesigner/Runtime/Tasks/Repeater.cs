using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class Repeater : Decorator
	{
		public SharedInt count;
		public SharedBool repeatForever;
		public SharedBool endOnFailure;
	}
}
