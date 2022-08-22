using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubLight : Command
{
    public override void Excute()
    {
        TurnOn();
    }

    public void TurnOn()
    {
        Debug.Log("MainLigth On");
    }
}
