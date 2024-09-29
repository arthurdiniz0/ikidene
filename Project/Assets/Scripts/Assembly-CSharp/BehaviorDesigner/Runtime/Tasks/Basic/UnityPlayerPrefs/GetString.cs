using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPlayerPrefs
{
	public class GetString : Action
	{
		public SharedString key;
		public SharedString defaultValue;
		public SharedString storeResult;
	}
}
