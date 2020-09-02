using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class ARBB : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject propic, favhero, favgame;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for(int i = 0; i < (vrb.Length); i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        propic.SetActive(false);
        favhero.SetActive(false);
        favgame.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        if (vb.VirtualButtonName == "PROPIC")
        {
            propic.SetActive(true);
            favhero.SetActive(false);
            favgame.SetActive(false);
        }

        else if(vb.VirtualButtonName == "HERO")
        {
            propic.SetActive(false);
            favhero.SetActive(true);
            favgame.SetActive(false);
        }

        else if (vb.VirtualButtonName == "GAME")
        {
            propic.SetActive(false);
            favhero.SetActive(false);
            favgame.SetActive(true);
        }

        else
        {
            throw new UnityException(vb.VirtualButtonName + "virtual button");
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual button released.");
    }


}
