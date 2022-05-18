[System.Serializable]
public class JsonMapAccountList
{
    public string baseDate;
    public string baseTime;
    public Accounts[] accounts;
    public SpAccounts[] spAccounts;

    [System.Serializable]
    public class Accounts
    {
        public string accountId;
        public string branchCode;
        public string branchName;
        public string accountTypeCode;
        public string accountTypeName;
        public string accountNumber;
        public string primaryAccountCode;
        public string primaryAccountCodeName;
        public string accountName;
        public string accountNameKana;
        public string currencyCode;
        public string currencyName;
        public string transferLimitAmount;
    }

    [System.Serializable]
    public class SpAccounts
    {
        public string accountId;
        public string spAccountTypeCode;
        public string spAccountTypeCodeName;
        public string spAccountName;
        public string spAccountBranchCode;
        public string spAccountBranchName;
        public string spAccountNumber;
    }
}
