﻿namespace Giant.Core
{
	public static class IdGenerater
	{
		public static long AppId { private get; set; }

		private static ushort value;

		public static long GenerateId()
		{
			long time = TimeHelper.NowSeconds();

			return (AppId << 48) + (time << 16) + ++value;
		}

		public static int GetAppIdFromId(long id)
		{
			return (int)(id >> 48);
		}
	}
}