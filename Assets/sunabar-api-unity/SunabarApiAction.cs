using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunabarApiAction : MonoBehaviour
{
    private static string sunabarApiToken = "トークンをここに入れる"; //トークンをここに入れる
    
    public static string GetMainAccountId()
    {
        JsonMapAccountList json = SunabarApiRequest.GetAccountList(sunabarApiToken);
        string mainAccountId = json.spAccounts[0].accountId;
        Debug.Log("Get MainAccountId " + mainAccountId);
        return mainAccountId;
    }

    public static string GetAppAccountId()
    {
        JsonMapAccountList json = SunabarApiRequest.GetAccountList(sunabarApiToken);
        string appAccountId = json.spAccounts[1].accountId;
        Debug.Log("Get AppAccountId " + appAccountId);
        return appAccountId;
    }

    public static string GetMainAccountBalance()
    {
        JsonMapAccountBalances json = SunabarApiRequest.GetAccountBalances(sunabarApiToken, GetMainAccountId());
        string mainAccountBalance = json.spAccountBalances[0].odBalance;
        Debug.Log("Get MainAccountBalance " + mainAccountBalance);
        return mainAccountBalance;
    }

    public static string GetAppAccountBalance()
    {
        JsonMapAccountBalances json = SunabarApiRequest.GetAccountBalances(sunabarApiToken, GetAppAccountId());
        string appAccountBalance = json.spAccountBalances[0].odBalance;
        Debug.Log("Get AppAccountBalance " + appAccountBalance);
        return appAccountBalance;
    }
    
    public static void DoTransfer(string paymentAmount)
    {
        JsonMapDoTransferRecv json = SunabarApiRequest.DoTransfer(sunabarApiToken, GetMainAccountId(), GetAppAccountId(), paymentAmount);
        Debug.Log(paymentAmount + " transferred");
    }

    public static void UndoTransfer(string paymentAmount)
    {
        JsonMapDoTransferRecv json = SunabarApiRequest.DoTransfer(sunabarApiToken, GetAppAccountId(), GetMainAccountId(), paymentAmount);
        Debug.Log(paymentAmount + " refunded");
    }
}
