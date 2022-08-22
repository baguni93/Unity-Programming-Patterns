using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpValueCommand : Command
{
    private LightObject lightObject;

    public UpValueCommand(LightObject lightObject){
        this.lightObject = lightObject;
    }
    public override void Excute()
    {
        lightObject.UpValue();
    }
}
