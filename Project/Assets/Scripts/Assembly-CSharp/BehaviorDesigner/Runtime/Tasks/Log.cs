using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class Log : Action
	{
		public SharedString text;
		public SharedBool logError;
	}
}
