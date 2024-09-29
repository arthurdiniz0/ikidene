using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPlayerPrefs
{
	public class SetInt : Action
	{
		public SharedString key;
		public SharedInt value;
	}
}
