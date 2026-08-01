public interface ITutParameter
{
	TutType type { get; set; }

	string tittle { get; set; }

	float delayEnable { get; set; }

	bool RequireTouchToTarget { get; set; }

	bool DisableMask { get; set; }
}
