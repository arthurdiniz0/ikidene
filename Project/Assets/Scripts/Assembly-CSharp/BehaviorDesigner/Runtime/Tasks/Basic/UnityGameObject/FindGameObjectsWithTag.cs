using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class FindGameObjectsWithTag : Action
	{
		public SharedString tag;
		public SharedGameObjectList storeValue;
	}
}
