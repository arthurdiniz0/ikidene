using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class FindWithTag : Action
	{
		public SharedString tag;
		public SharedBool random;
		public SharedGameObject storeValue;
	}
}
