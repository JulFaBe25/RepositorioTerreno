using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Panel;
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
    {
        PanelOff();
    }
    }

    public void PanelOn()
    { 
        Panel.SetActive(true);
    }


    public void PanelOff()
    { 
        Panel.SetActive(false);
    }

    void OnTriggerEnter(Collider Other)
    {
        if( Other.CompareTag("NPC"))
        {
            PanelOn();
        }
    }

    void OnTriggerExit (Collider Other)
    {
        PanelOff();
    }
}

