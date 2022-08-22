using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnCommand : Command
{
    private LightObject lightObject;

    public TurnOnCommand(LightObject lightObject)
    {
        this.lightObject = lightObject;
    }
    public override void Excute()
    {
        lightObject.TurnOn();
    }
}
