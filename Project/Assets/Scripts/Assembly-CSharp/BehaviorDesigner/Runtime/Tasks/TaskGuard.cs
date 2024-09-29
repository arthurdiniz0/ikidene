using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class TaskGuard : Decorator
	{
		public SharedInt maxTaskAccessCount;
		public TaskGuard[] linkedTaskGuards;
		public SharedBool waitUntilTaskAvailable;
	}
}
