using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Refresh : MonoBehaviour
{
    public Text mainAccountIdLable;
    public Text appAccountIdLable;
    public Text mainAccountBalanceLabel;
    public Text appAccountBalanceLabel;

    public void RefreshClick()
    {
        mainAccountIdLable.text = "MainAccountId: " + SunabarApiAction.GetMainAccountId();
        appAccountIdLable.text = "AppAccountId: " + SunabarApiAction.GetAppAccountId();
        mainAccountBalanceLabel.text = "MainAccountBalance: " + SunabarApiAction.GetMainAccountBalance();
        appAccountBalanceLabel.text = "AppAccountBalance: " + SunabarApiAction.GetAppAccountBalance();
    }

    void Start()
    {
        mainAccountIdLable.text = "MainAccountId: SP00000000000";
        appAccountIdLable.text = "AppAccountId: SP00000000000";
        mainAccountBalanceLabel.text = "MainAccountBalance: 0";
        appAccountBalanceLabel.text = "AppAccountBalance: 0";
    }
}
