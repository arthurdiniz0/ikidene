using UnityEngine;
using System.Collections.Generic;

namespace PsychoticLab
{
	public class CharacterRandomizer : MonoBehaviour
	{
		public bool repeatOnPlay;
		public float shuffleSpeed;
		public Material mat;
		public Color[] primary;
		public Color[] secondary;
		public Color[] metalPrimary;
		public Color[] metalSecondary;
		public Color[] leatherPrimary;
		public Color[] leatherSecondary;
		public Color[] whiteSkin;
		public Color[] brownSkin;
		public Color[] blackSkin;
		public Color[] elfSkin;
		public Color[] whiteHair;
		public Color whiteStubble;
		public Color[] brownHair;
		public Color brownStubble;
		public Color[] blackHair;
		public Color blackStubble;
		public Color[] elfHair;
		public Color elfStubble;
		public Color whiteScar;
		public Color brownScar;
		public Color blackScar;
		public Color elfScar;
		public Color[] bodyArt;
		public List<GameObject> enabledObjects;
		public CharacterObjectGroups male;
		public CharacterObjectGroups female;
		public CharacterObjectListsAllGender allGender;
	}
}
