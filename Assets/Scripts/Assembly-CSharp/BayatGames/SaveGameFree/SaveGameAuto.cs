using System.Text;
using BayatGames.SaveGameFree.Encoders;
using BayatGames.SaveGameFree.Serializers;
using UnityEngine;

namespace BayatGames.SaveGameFree
{
	[AddComponentMenu("Save Game Free/Auto Save")]
	public class SaveGameAuto : MonoBehaviour
	{
		public enum SaveFormat
		{
			XML = 0,
			JSON = 1,
			Binary = 2
		}

		[Space]
		[Tooltip("You must specify a value for this to be able to save it.")]
		[Header("Settings")]
		public string positionIdentifier;

		[Tooltip("You must specify a value for this to be able to save it.")]
		public string rotationIdentifier;

		[Tooltip("You must specify a value for this to be able to save it.")]
		public string scaleIdentifier;

		[Tooltip("Encode the data?")]
		public bool encode;

		[Tooltip("If you leave it blank this will reset to it's default value.")]
		public string encodePassword;

		[Tooltip("Which serialization format?")]
		public SaveFormat format;

		[Tooltip("If you leave it blank this will reset to it's default value.")]
		public ISaveGameSerializer serializer;

		[Tooltip("If you leave it blank this will reset to it's default value.")]
		public ISaveGameEncoder encoder;

		[Tooltip("If you leave it blank this will reset to it's default value.")]
		public Encoding encoding;

		[Tooltip("Where to save? (PersistentDataPath highly recommended).")]
		public SaveGamePath savePath;

		[Tooltip("Reset the empty fields to their default value.")]
		public bool resetBlanks;

		[Header("What to Save?")]
		[Space]
		[Tooltip("Save Position?")]
		public bool savePosition;

		[Tooltip("Save Rotation?")]
		public bool saveRotation;

		[Tooltip("Save Scale?")]
		public bool saveScale;

		[Header("Defaults")]
		[Space]
		[Tooltip("Default Position Value")]
		public Vector3 defaultPosition;

		[Tooltip("Default Rotation Value")]
		public Vector3 defaultRotation;

		[Tooltip("Default Scale Value")]
		public Vector3 defaultScale;

		[Tooltip("Save on Awake()")]
		[Space]
		[Header("Save Events")]
		public bool saveOnAwake;

		[Tooltip("Save on Start()")]
		public bool saveOnStart;

		[Tooltip("Save on OnEnable()")]
		public bool saveOnEnable;

		[Tooltip("Save on OnDisable()")]
		public bool saveOnDisable;

		[Tooltip("Save on OnApplicationQuit()")]
		public bool saveOnApplicationQuit;

		[Tooltip("Save on OnApplicationPause()")]
		public bool saveOnApplicationPause;

		[Space]
		[Tooltip("Load on Awake()")]
		[Header("Load Events")]
		public bool loadOnAwake;

		[Tooltip("Load on Start()")]
		public bool loadOnStart;

		[Tooltip("Load on OnEnable()")]
		public bool loadOnEnable;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnApplicationQuit()
		{
		}

		protected virtual void OnApplicationPause()
		{
		}

		public virtual void Save()
		{
		}

		public virtual void Load()
		{
		}
	}
}
