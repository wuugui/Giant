﻿using Giant.Msg;
using Giant.Net;
using Giant.Share;
using System.Threading.Tasks;

namespace Server.Frame
{
    [MessageHandler(AppType.AllServer)]
    public class Handle_StopApp : MHandler<Msg_GM_StopApp>
    {
        public override async Task Run(Session session, Msg_GM_StopApp message)
        {
            if (Framework.AppId == message.AppId)
            {
                Framework.BaseService.StopApp();
            }
            await Task.CompletedTask;
        }
    }
}
