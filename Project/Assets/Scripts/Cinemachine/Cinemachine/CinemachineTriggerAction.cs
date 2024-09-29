using UnityEngine;
using System;
using UnityEngine.Events;

namespace Cinemachine
{
	public class CinemachineTriggerAction : MonoBehaviour
	{
		[Serializable]
		public struct ActionSettings
		{
			[Serializable]
			public class TriggerEvent : UnityEvent
			{
			}

			public enum Mode
			{
				Custom = 0,
				PriorityBoost = 1,
				Activate = 2,
				Deactivate = 3,
				Enable = 4,
				Disable = 5,
				Play = 6,
				Stop = 7,
			}

			public enum TimeMode
			{
				FromStart = 0,
				FromEnd = 1,
				BeforeNow = 2,
				AfterNow = 3,
			}

			public ActionSettings(CinemachineTriggerAction.ActionSettings.Mode action) : this()
			{
			}

			public Mode m_Action;
			public Object m_Target;
			public int m_BoostAmount;
			public float m_StartTime;
			public TimeMode m_Mode;
			public TriggerEvent m_Event;
		}

		public LayerMask m_LayerMask;
		public string m_WithTag;
		public string m_WithoutTag;
		public int m_SkipFirst;
		public bool m_Repeating;
		public ActionSettings m_OnObjectEnter;
		public ActionSettings m_OnObjectExit;
	}
}
