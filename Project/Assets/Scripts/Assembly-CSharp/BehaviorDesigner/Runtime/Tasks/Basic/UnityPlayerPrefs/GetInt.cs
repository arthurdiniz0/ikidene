using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPlayerPrefs
{
	public class GetInt : Action
	{
		public SharedString key;
		public SharedInt defaultValue;
		public SharedInt storeResult;
	}
}
