using UnityEngine;

public class BookPuzzle : MonoBehaviour
{
    GreenSlot gsScript;
    BlueSlot bsScript;
    RedSlot rsScript;
    PinkSlot psScript;
    YellowSlot ysScript;

    public GameObject uiObj;
    Lvl2UIManager uiScript;

    public GameObject bookSlot1;
    public GameObject bookSlot2;
    public GameObject bookSlot3;
    public GameObject bookSlot4;
    public GameObject bookSlot5;

    public GameObject endLvlTrigger;

     void Start()
     {
        gsScript = bookSlot1.GetComponent<GreenSlot>();
        bsScript = bookSlot2.GetComponent<BlueSlot>();
        rsScript = bookSlot3.GetComponent<RedSlot>();
        psScript = bookSlot4.GetComponent<PinkSlot>();
        ysScript = bookSlot5.GetComponent<YellowSlot>();
        uiScript = uiObj.GetComponent<Lvl2UIManager>();
    }


    void Update()
    {
        if (gsScript != null && bsScript != null && rsScript != null && psScript != null && ysScript != null)
        {
            //Debug.Log("Bookshelf has all slot scripts");

            if (gsScript.isSlotFull == true && bsScript.isSlotFull == true && rsScript.isSlotFull == true 
                && psScript.isSlotFull == true && ysScript.isSlotFull == true)
            {
                if (endLvlTrigger != null)
                {
                    endLvlTrigger.SetActive(true);
                    uiScript.UIUpdateFinal();
                }
                

            }
        }
        else
        {
            Debug.Log("Cant find all slot scripts");
        }
        
    }
}
