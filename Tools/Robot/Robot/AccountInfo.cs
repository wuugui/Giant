﻿namespace Robort
{
    class AccountInfo
    {
        public string Account { get; private set; }
        public string Passward { get;  private set; }

        public AccountInfo(string account, string passward)
        {
            this.Account = account;
            this.Passward = passward;
        }
    }
}
