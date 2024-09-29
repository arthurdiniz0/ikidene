using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPlayerPrefs
{
	public class SetFloat : Action
	{
		public SharedString key;
		public SharedFloat value;
	}
}
