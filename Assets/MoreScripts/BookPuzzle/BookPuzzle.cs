using UnityEngine;

public class BookPuzzle : MonoBehaviour
{
    GreenSlot gsScript;
    BlueSlot bsScript;
    RedSlot rsScript;
    PinkSlot psScript;
    YellowSlot ysScript;

    public GameObject bookSlot1;
    public GameObject bookSlot2;
    public GameObject bookSlot3;
    public GameObject bookSlot4;
    public GameObject bookSlot5;

     void Start()
     {
        gsScript = bookSlot1.GetComponent<GreenSlot>();
        bsScript = bookSlot2.GetComponent<BlueSlot>();
        rsScript = bookSlot3.GetComponent<RedSlot>();
        psScript = bookSlot4.GetComponent<PinkSlot>();
        ysScript = bookSlot5.GetComponent<YellowSlot>();
     }


    void Update()
    {
        if (gsScript != null && bsScript != null && rsScript != null && psScript != null && ysScript != null)
        {
            Debug.Log("Bookshelf has all slot scripts");

            if (gsScript.isSlotFull == true && bsScript.isSlotFull == true && rsScript.isSlotFull == true 
                && psScript.isSlotFull == true && ysScript.isSlotFull == true)
            {

                Debug.Log("Player can go to next level now!!!"); // delete this and insert opening of next level here

            }
        }
        else
        {
            Debug.Log("Cant find all slot scripts");
        }
        
    }
}
