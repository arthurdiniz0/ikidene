using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetVelocityUpdateMode : Action
	{
		public SharedGameObject targetGameObject;
		public AudioVelocityUpdateMode velocityUpdateMode;
	}
}
