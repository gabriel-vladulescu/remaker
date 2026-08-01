using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetUserSeasonProgressesAndRewardStatus
	{
		private class Response
		{
			public bool success;

			public StatusCode statusCode;

			public string message;
		}

		private HttpEndPoints endPoints;

		private SeasonsAndReward[] seasonsAndRewards;

		private string userId;

		private bool isFinishReadingSeasonProgresses;

		private bool isErrorReadingSeasonProgresses;

		private bool isFinishReadingRewardStatus;

		private bool isErrorReadingRewardStatus;

		private bool isRewardClaimed;

		private bool isFinishReadingPreviousSeasonId;

		private bool isErrorReadingPreviousSeasonId;

		private GetUserSeasonProgressesAndRewardStatusResult seasonProgresses;

		private Action<bool, StatusCode, string, GetUserSeasonProgressesAndRewardStatusResult> callback;

		private StatusCode seasonProgressesReadingStatusCode;

		private Response seasonProgressesResponse;

		private Response previousSeasonIdResponse;

		private Response rewardClaimStatusResponse;

		public GetUserSeasonProgressesAndRewardStatus(HttpEndPoints endPoints, SeasonsAndReward[] seasonsAndRewards, string userId)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetUserSeasonProgressesAndRewardStatusResult> callback)
		{
		}

		private void ReadRewardStatusFromDifferentSource()
		{
		}

		private void OnDataReady()
		{
		}
	}
}
