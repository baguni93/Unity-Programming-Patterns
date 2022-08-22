using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedRoomLight : Command
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
