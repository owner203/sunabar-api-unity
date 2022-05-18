[System.Serializable]
public class JsonMapAccountBalances
{
    public Balances[] balances;
    public SpAccountBalances[] spAccountBalances;

    [System.Serializable]
    public class Balances
    {
        public string accountId;
        public string accountTypeCode;
        public string accountTypeName;
        public string balance;
        public string baseDate;
        public string baseTime;
        public string withdrawableAmount;
        public string previousDayBalance;
        public string previousMonthBalance;
        public string currencyCode;
        public string currencyName;
    }

    [System.Serializable]
    public class SpAccountBalances
    {
        public string accountId;
        public string odBalance;
        public string tdTotalBalance;
        public string fodTotalBalanceYenEquivalent;
        public SpAccountFcyBalances[] spAccountFcyBalances;

        [System.Serializable]
        public class SpAccountFcyBalances
        {
            public string currencyCode;
            public string currencyName;
            public string fcyTotalBalance;
            public string ttb;
            public string baseRateDate;
            public string baseRateTime;
            public string yenEquivalent;
        }
    }
}
