using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller
{

    private PlayerModel model;
    private PlayerView view;

    public PlayerContoller(PlayerModel model,PlayerView view)
    {
        this.model = model;
        this.view = view;
    }


    public void SetPlayerName(string name)
    {
        model.SetName(name);
    }


    public string GetPlayerName()
    {
        return model.GetName();
    }


    public void UpdateView()
    {
        view.Show(model.GetName());
    }

}
