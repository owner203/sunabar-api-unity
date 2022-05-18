using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transfer500 : MonoBehaviour
{
    public void Transfer500Click()
    {
        SunabarApiAction.DoTransfer("500");
    }
}
