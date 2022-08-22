using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotingCommand : Command
{
    private LightObject lightObject;

    public DoNotingCommand(LightObject lightObject)
    {
        this.lightObject = lightObject;
    }
    public override void Excute()
    {
        
    }
}
