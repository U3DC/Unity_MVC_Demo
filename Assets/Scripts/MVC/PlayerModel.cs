using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    private string _name;

    public void SetName(string name)
    {
        _name = name;
    }


    public string GetName()
    {
        return _name;
    }
}

