using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Command command;

    private void SetMainLightOn(){
        command.Excute();
    }

    private void SetSubLightOn(){
        command.Excute();
    }

    private void SetBedRoomLightOn(){
        command.Excute();
    }
}
