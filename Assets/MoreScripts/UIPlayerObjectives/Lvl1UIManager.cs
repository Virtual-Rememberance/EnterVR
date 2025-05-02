using System;
using TMPro;
using UnityEngine;

public class Lvl1UIManager : MonoBehaviour
{
    public Canvas playerCanvas;

    public TextMeshProUGUI firstObjvText;
    public TextMeshProUGUI finalObjvText;
    void Awake()
    {

        BringUpUI();
        
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

   
   public void BringUpUI()
   {
        playerCanvas = GetComponent<Canvas>();
        playerCanvas.enabled = true;
   }
}
