using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetRolloffMode : Action
	{
		public SharedGameObject targetGameObject;
		public AudioRolloffMode rolloffMode;
	}
}
