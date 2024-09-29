using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityString
{
	public class Format : Action
	{
		public SharedString format;
		public SharedGenericVariable[] variables;
		public SharedString storeResult;
	}
}
