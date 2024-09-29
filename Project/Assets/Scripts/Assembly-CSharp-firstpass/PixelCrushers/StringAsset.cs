using UnityEngine;

namespace PixelCrushers
{
	public class StringAsset : ScriptableObject
	{
		[TextAreaAttribute]
		[SerializeField]
		private string m_text;
	}
}
