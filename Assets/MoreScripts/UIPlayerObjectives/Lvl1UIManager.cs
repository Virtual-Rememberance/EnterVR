using TMPro;
using UnityEngine;

public class Lvl1UIManager : MonoBehaviour
{
    public Canvas playerCanvas;

    public TextMeshProUGUI firstObjvText;
    public TextMeshProUGUI finalObjvText;
    void Awake()
    {
        //play intro audio, when this audio is over turn on Player UI

        playerCanvas = GetComponent<Canvas>();

        playerCanvas.enabled = true;

        
    }

    public void UpdateUI()
    {
        if (playerCanvas != null)
        {
            if (firstObjvText.enabled == true)
            {
                firstObjvText.enabled = false;
                finalObjvText.enabled = true;
            }

        }
    }

   
   
}
