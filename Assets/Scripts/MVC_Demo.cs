using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class MVC_Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerModel model = new PlayerModel();
        PlayerView view = new PlayerView();
        PlayerContoller contoller = new PlayerContoller(model, view);
        contoller.SetPlayerName("公主");
        contoller.UpdateView();
    }
   
}
