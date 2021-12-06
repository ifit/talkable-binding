using ObjCRuntime;

namespace TalkableApi
{
	[Native]
	public enum TKBLOriginType : ulong
	{
		AffiliateMember = 0,
		Purchase,
		Event
	}

	[Native]
	public enum TKBLError : ulong
	{
		NetworkError = 1000,
		ApiError = 1001,
		RequestError = 1002,
		CampaignError = 1003
	}
}
