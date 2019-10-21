﻿using CommandLine;
using Giant.Share;
using System;

namespace Server.Frame
{
    public static class Framework
    {
        public static AppOption AppOption { get; private set; }
        public static BaseAppService BaseService { get; private set; }

        public static AppState AppState { get; set; }

        public static AppType AppType => AppOption.AppType;
        public static int AppId => AppOption.AppId;
        public static int SubId => AppOption.SubId;

        public static BaseServerCreater ServerCreater => BaseService.ServerCreater;

        internal static void Init(BaseAppService service, string[] args)
        {
            Parser.Default.ParseArguments<AppOption>(args)
                .WithNotParsed(error => throw new Exception("CommandLine param error !"))
                .WithParsed(options => { AppOption = options; });

            BaseService = service;
        }
    }
}
