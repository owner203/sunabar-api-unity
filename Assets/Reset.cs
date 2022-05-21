using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void ResetClick()
    {
        SunabarApiAction.UndoTransfer(SunabarApiAction.GetAppAccountBalance());
    }
}
