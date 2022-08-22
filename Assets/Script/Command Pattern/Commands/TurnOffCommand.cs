using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCommand : Command
{
    private LightObject lightObject;

    public TurnOffCommand(LightObject lightObject)
    {
        this.lightObject = lightObject;
    }
    public override void Excute()
    {
        lightObject.TurnOff();
    }
}
