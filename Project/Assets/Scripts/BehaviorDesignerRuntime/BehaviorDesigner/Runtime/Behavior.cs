using System;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	[Serializable]
	public class Behavior : MonoBehaviour
	{
		[SerializeField]
		private bool startWhenEnabled;
		[SerializeField]
		private bool pauseWhenDisabled;
		[SerializeField]
		private bool restartWhenComplete;
		[SerializeField]
		private bool logTaskChanges;
		[SerializeField]
		private int group;
		[SerializeField]
		private bool resetValuesOnRestart;
		[SerializeField]
		private ExternalBehavior externalBehavior;
		[SerializeField]
		private BehaviorSource mBehaviorSource;
	}
}
