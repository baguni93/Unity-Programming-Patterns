using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownValueCommand : Command
{
    private LightObject lightObject;

    public DownValueCommand(LightObject lightObject)
    {
        this.lightObject = lightObject;
    }
    public override void Excute()
    {
        lightObject.DownValue();
    }
}
