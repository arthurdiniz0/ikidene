using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLayerMask
{
	public class SetLayer : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString layerName;
	}
}
