using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayPlay_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SoundManager _003C_003E4__this;

		public AudioClip musicClip;

		public float volume;

		public float time;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayPlay_003Ed__26(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int audioPoolSize;

	private Dictionary<AudioSource, string> audioSourcePool;

	private AudioSource currentMusicAudioSource;

	[HideInInspector]
	public float delayPlay;

	private List<UISfx> exceptList;

	public float fadeTime;

	private AudioSource musicAudioSourceA;

	private AudioSource musicAudioSourceB;

	private Tweener musicFadeInTweener;

	private Tweener musicFadeOutTweener;

	[HideInInspector]
	public bool muteMusic;

	[HideInInspector]
	public bool muteSfx;

	private AudioSource[] sfxAudioSourceArray;

	private Dictionary<string, AudioClip> sfxClipsCache;

	private AudioSource sourcePlayAmbience;

	private MusicScene cachedMusicScene;

	private Ambience cachedAmbience;

	private MusicScene curMusicScene;

	private Ambience curAmbience;

	private Dictionary<string, int> sfxCap;

	private void Awake()
	{
	}

	private void InitConfigCapSfx()
	{
	}

	private AudioSource getSourceFromPool(AudioClip clip = null)
	{
		return null;
	}

	private void playMusic(string path, float time)
	{
	}

	public void playMusic(MusicScene musicScene, float fadeTime = 0f)
	{
	}

	private void playMusic(string path, float volume, float time)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayPlay_003Ed__26))]
	private IEnumerator DelayPlay(AudioClip musicClip, float volume, float time)
	{
		return null;
	}

	private void doMusicCrossFade(AudioClip musicClip, float endVolume)
	{
	}

	private void doMusicCrossFade(AudioClip musicClip, float startVolume, float endVolume)
	{
	}

	private void musicCrossFadeComplete()
	{
	}

	private void doMusicPlay(AudioClip musicClip, float startVolume, float endVolume, float time)
	{
	}

	private void doMusicPlay(AudioClip musicClip, float volume, float time)
	{
	}

	public void stopMusic()
	{
	}

	public void ReplayMusic()
	{
	}

	public void fadeOutMusic(float time)
	{
	}

	public void fadeOutMusic(AudioSource musicSource, float time = 0f)
	{
	}

	public void fadeOutSfx(string path, float time = 0f)
	{
	}

	public void doneMusicFade(AudioSource fadedTargetAudioSource)
	{
	}

	public void MuteMusic(bool value)
	{
	}

	private void debugMusic(string output)
	{
	}

	public bool SfxIsPlaying(AudioClip soundClip)
	{
		return false;
	}

	public void playSfx(AudioClip clip, bool checkInterrupt, float volume, bool loop, float speed)
	{
	}

	private List<AudioSource> GetAudioSourcesPlayClip(AudioClip clip)
	{
		return null;
	}

	private void PlaySfx(string soundPath, float volume, bool loop = false, bool checkInterrupt = false, float speed = 1f, Action<string, AudioClip> callback = null)
	{
	}

	public void PlaySfx(UISfx uiSfx, bool loop = false, bool checkInterrupt = false)
	{
	}

	public void PlayGamSfx(SoundGroup soundGroup, string path, float speed = 1f, bool checkInterrupt = false, Action<string, AudioClip> callback = null)
	{
	}

	public void PlayGameSfx(SoundGroup soundGroup, string path, bool loop = false, float speed = 1f, bool checkInterrupt = false, Action<string, AudioClip> callback = null)
	{
	}

	public void StopSfx(UISfx uiSFX)
	{
	}

	public void StopSfx(AudioClip audioClip)
	{
	}

	public void StopSfx()
	{
	}

	public void MuteSound(bool value)
	{
	}

	public void PlayAmbience(Ambience ambience)
	{
	}

	private void playAmbience(AudioClip clip, float volume)
	{
	}

	public void StopAmbience()
	{
	}

	public void ReplayAmbience()
	{
	}

	public void Suspend()
	{
	}

	public void Continue()
	{
	}

	public void LoadSound(string path, Action<AudioClip> onSuccess)
	{
	}

	public void CacheBgmAndAmbience()
	{
	}

	public void ReplayBgmAndAmbience()
	{
	}

	public void ClearCacheBgmAndAmbience()
	{
	}

	private bool IsReachLimit(AudioClip clip)
	{
		return false;
	}
}
