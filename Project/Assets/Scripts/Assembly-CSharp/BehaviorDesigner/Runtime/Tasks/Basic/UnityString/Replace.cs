using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityString
{
	public class Replace : Action
	{
		public SharedString targetString;
		public SharedString oldString;
		public SharedString newString;
		public SharedString storeResult;
	}
}
