using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPlayerPrefs
{
	public class SetString : Action
	{
		public SharedString key;
		public SharedString value;
	}
}
