using System;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class MessageEvents : MonoBehaviour
	{
		[Serializable]
		public class MessageEvent
		{
			public GameObject requiredSender;
			public GameObject requiredTarget;
			public StringField message;
			public StringField parameter;
			public MessageArgsEvent onMessage;
		}

		[Serializable]
		public class MessageToSend
		{
			public GameObject target;
			public StringField message;
			public StringField parameter;
		}

		[SerializeField]
		private MessageEvent[] m_messagesToListenFor;
		[SerializeField]
		private MessageToSend[] m_messagesToSend;
	}
}
