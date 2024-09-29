using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	public class TriggeredSpawner : MonoBehaviour
	{
		public enum Unity_UIVersion
		{
			Legacy = 0,
		}

		public enum WavePauseBehavior
		{
			BehaveAsNormal = 0,
			Disable = 1,
		}

		public enum SpawnerEventSource
		{
			ReceiveFromParent = 0,
			Self = 1,
			None = 2,
		}

		public enum RetriggerLimitMode
		{
			None = 0,
			FrameBased = 1,
			TimeBased = 2,
		}

		public enum GameOverBehavior
		{
			BehaveAsNormal = 0,
			Disable = 1,
		}

		public enum EventType
		{
			OnEnabled = 0,
			OnDisabled = 1,
			Visible = 2,
			Invisible = 3,
			MouseOver_Legacy = 4,
			MouseClick_Legacy = 5,
			OnCollision = 6,
			OnTriggerEnter = 7,
			OnSpawned = 8,
			OnDespawned = 9,
			OnClick_NGUI = 10,
			CodeTriggered1 = 11,
			CodeTriggered2 = 12,
			LostHitPoints = 13,
			OnTriggerExit = 14,
			OnCollision2D = 15,
			OnTriggerEnter2D = 16,
			OnTriggerExit2D = 17,
			SpawnerDestroyed = 18,
			DeathTimer = 19,
			CustomEvent = 20,
			SliderChanged_uGUI = 21,
			ButtonClicked_uGUI = 22,
			PointerDown_uGUI = 23,
			PointerUp_uGUI = 24,
			PointerEnter_uGUI = 25,
			PointerExit_uGUI = 26,
			Drag_uGUI = 27,
			Drop_uGUI = 28,
			Scroll_uGUI = 29,
			UpdateSelected_uGUI = 30,
			Select_uGUI = 31,
			Deselect_uGUI = 32,
			Move_uGUI = 33,
			InitializePotentialDrag_uGUI = 34,
			BeginDrag_uGUI = 35,
			EndDrag_uGUI = 36,
			Submit_uGUI = 37,
			Cancel_uGUI = 38,
			ParentDestroyed = 39,
			DistanceDeath = 40,
		}

		public Unity_UIVersion unityUIMode;
		public bool logMissingEvents;
		public LevelSettings.ActiveItemMode activeMode;
		public WorldVariableRangeCollection activeItemCriteria;
		public GameOverBehavior gameOverBehavior;
		public WavePauseBehavior wavePauseBehavior;
		public SpawnerEventSource eventSourceType;
		public bool transmitEventsToChildren;
		public WaveSyncroPrefabSpawner.SpawnLayerTagMode spawnLayerMode;
		public WaveSyncroPrefabSpawner.SpawnLayerTagMode spawnTagMode;
		public int spawnCustomLayer;
		public string spawnCustomTag;
		public TriggeredSpawnerListener listener;
		public TriggeredWaveSpecifics enableWave;
		public TriggeredWaveSpecifics disableWave;
		public TriggeredWaveSpecifics visibleWave;
		public TriggeredWaveSpecifics invisibleWave;
		public TriggeredWaveSpecifics mouseOverWave;
		public TriggeredWaveSpecifics mouseClickWave;
		public TriggeredWaveSpecifics collisionWave;
		public TriggeredWaveSpecifics triggerEnterWave;
		public TriggeredWaveSpecifics triggerExitWave;
		public TriggeredWaveSpecifics spawnedWave;
		public TriggeredWaveSpecifics despawnedWave;
		public TriggeredWaveSpecifics codeTriggeredWave1;
		public TriggeredWaveSpecifics codeTriggeredWave2;
		public TriggeredWaveSpecifics clickWave;
		public TriggeredWaveSpecifics collision2dWave;
		public TriggeredWaveSpecifics triggerEnter2dWave;
		public TriggeredWaveSpecifics triggerExit2dWave;
		public List<TriggeredWaveSpecifics> userDefinedEventWaves;
		public TriggeredWaveSpecifics unitySliderChangedWave;
		public TriggeredWaveSpecifics unityButtonClickedWave;
		public TriggeredWaveSpecifics unityPointerDownWave;
		public TriggeredWaveSpecifics unityPointerUpWave;
		public TriggeredWaveSpecifics unityPointerEnterWave;
		public TriggeredWaveSpecifics unityPointerExitWave;
		public TriggeredWaveSpecifics unityDragWave;
		public TriggeredWaveSpecifics unityDropWave;
		public TriggeredWaveSpecifics unityScrollWave;
		public TriggeredWaveSpecifics unityUpdateSelectedWave;
		public TriggeredWaveSpecifics unitySelectWave;
		public TriggeredWaveSpecifics unityDeselectWave;
		public TriggeredWaveSpecifics unityMoveWave;
		public TriggeredWaveSpecifics unityInitializePotentialDragWave;
		public TriggeredWaveSpecifics unityBeginDragWave;
		public TriggeredWaveSpecifics unityEndDragWave;
		public TriggeredWaveSpecifics unitySubmitWave;
		public TriggeredWaveSpecifics unityCancelWave;
	}
}
