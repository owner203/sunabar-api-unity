using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;

public class SunabarApiRequest : MonoBehaviour
{
    public static JsonMapAccountList GetAccountList(string sunabarApiToken)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.sunabar.gmo-aozora.com/personal/v1/accounts");
        request.Accept = "application/json;charset=UTF-8";
        request.ContentType = "application/json";
        request.Headers.Add("x-access-token", sunabarApiToken);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<JsonMapAccountList>(json);
    }

    public static JsonMapAccountBalances GetAccountBalances(string sunabarApiToken, string accountId)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.sunabar.gmo-aozora.com/personal/v1/accounts/balances?accountId=" + accountId);
        request.Accept = "application/json;charset=UTF-8";
        request.ContentType = "application/json";
        request.Headers.Add("x-access-token", sunabarApiToken);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<JsonMapAccountBalances>(json);
    }

    public static JsonMapDoTransferRecv DoTransfer(string sunabarApiToken, string debitSpAccountId, string depositSpAccountId, string paymentAmount)
    {
        string postData = "{ \"depositSpAccountId\": \"" + depositSpAccountId + "\", \"debitSpAccountId\": \"" + debitSpAccountId + "\", \"currencyCode\": \"JPY\", \"paymentAmount\": \"" + paymentAmount + "\" }";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.sunabar.gmo-aozora.com/personal/v1/transfer/spaccounts-transfer");
        request.Method = "POST";
        request.Accept = "application/json;charset=UTF-8";
        request.ContentType = "application/json";
        request.Headers.Add("x-access-token", sunabarApiToken);
        using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
        {
            writer.Write(postData);
        }
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        json = json.Replace("\"currencyName\"", ",\"currencyName\""); //バグ対応
        return JsonUtility.FromJson<JsonMapDoTransferRecv>(json);
    }
}
