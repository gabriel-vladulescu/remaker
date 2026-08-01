using System;
using Firebase.Database;

public class ReportCrash
{
	private static string path_to_main_character_data;

	private FirebaseDatabase firebaseDatabase;

	public ReportCrash(FirebaseDatabase firebaseDatabase)
	{
	}

	public void Report(ReportCrashInfo crashInfo, Action<bool, string> callback)
	{
	}
}
