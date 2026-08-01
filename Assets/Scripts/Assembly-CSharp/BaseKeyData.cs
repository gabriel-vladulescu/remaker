using System;

[Serializable]
public class BaseKeyData
{
	public int interval;

	public int maxKey;

	public float curKey;

	public string lastTimeRecovery;

	private long LastTimeRecovery
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public void SetCurrentKey(int value)
	{
	}

	public void ConsumeKey(int value)
	{
	}

	public void AddKey(int value)
	{
	}

	public void SetupConfig(int maxKey, int intervalInSeconds)
	{
	}

	public void SetKeyToMax()
	{
	}

	public int GetTimeToRecoveryFull()
	{
		return 0;
	}

	public int GetTimeToRecoveryNewKey()
	{
		return 0;
	}

	public float CurrentKeyNow()
	{
		return 0f;
	}

	public float CurrentKey(long utcNow, long keyCapacity, long intervalInSeconds)
	{
		return 0f;
	}

	public void autoRecoverKey(long curTime, int maxKey, int interval)
	{
	}

	private long calculateLastTimeRecovery(long lastTimeRecovery, int dkey, int step)
	{
		return 0L;
	}

	private int calculateKey(long lastTimeRecovery, long curTime, int step)
	{
		return 0;
	}
}
