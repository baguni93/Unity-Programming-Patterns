using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLightController : MonoBehaviour
{
    public LightObject lightObject;
    private Command turnOn;
    private Command turnOff;
    private Command upValue;
    private Command downValue;
    private void Start() 
    {
        turnOn = new TurnOnCommand(lightObject);
        turnOff = new TurnOffCommand(lightObject);
        upValue = new UpValueCommand(lightObject);
        downValue = new DownValueCommand(lightObject);
    }
    private void Update() {
        InputKeyDown();
    }
    private void InputKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ExecuteNewCommand(turnOn);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            ExecuteNewCommand(turnOff);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ExecuteNewCommand(upValue);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ExecuteNewCommand(downValue);
        }
    }

    private void ExecuteNewCommand(Command commandBtn)
    {
        commandBtn.Excute();
    }
}
