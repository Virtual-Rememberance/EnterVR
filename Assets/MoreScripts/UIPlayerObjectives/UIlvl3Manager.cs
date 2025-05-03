using UnityEngine;
using TMPro;

public class UIlvl3Manager : MonoBehaviour
{

    public TextMeshProUGUI caughtText;
    public TextMeshProUGUI objvText;
    public TextMeshProUGUI infoText;
    public GameObject backgroundPanel;


    private void Start()
    {
        Invoke("TurnOffObjective", 10);

    }



    public void TurnOffObjective()
    {
        if (objvText != null && infoText != null && backgroundPanel != null) 
        {
            backgroundPanel.SetActive(false);
            objvText.gameObject.SetActive(false);
            infoText.gameObject.SetActive(false);
        }
    }
    
    public void PlayerCaught()
    {
        if (caughtText != null) 
        {
            caughtText.gameObject.SetActive(true);
        
        }
    }


    public void PlayerCaughtOff()
    {
        if (caughtText != null)
        {
            caughtText.gameObject.SetActive(false);

        }

    }
}
