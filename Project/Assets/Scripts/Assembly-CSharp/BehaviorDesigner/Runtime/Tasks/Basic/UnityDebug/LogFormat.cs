using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityDebug
{
	public class LogFormat : Action
	{
		public SharedString textFormat;
		public SharedBool logError;
	}
}
