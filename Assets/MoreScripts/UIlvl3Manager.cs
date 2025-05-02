using UnityEngine;
using TMPro;

public class UIlvl3Manager : MonoBehaviour
{

    public TextMeshProUGUI caughtText;
    
    
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
