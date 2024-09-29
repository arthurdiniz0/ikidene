using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class SharedGameObjectsToGameObjectList : Action
	{
		public SharedGameObject[] gameObjects;
		public SharedGameObjectList storedGameObjectList;
	}
}
