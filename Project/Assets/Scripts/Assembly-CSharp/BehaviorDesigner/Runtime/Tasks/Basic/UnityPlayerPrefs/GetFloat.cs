using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPlayerPrefs
{
	public class GetFloat : Action
	{
		public SharedString key;
		public SharedFloat defaultValue;
		public SharedFloat storeResult;
	}
}
