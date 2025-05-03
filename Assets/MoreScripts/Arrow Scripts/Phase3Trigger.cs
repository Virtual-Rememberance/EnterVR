using UnityEngine;

public class Phase3Trigger : MonoBehaviour
{
    public GameObject[] itemsToToggle;
    private bool hasTriggered = false;

    public GameObject uiObj;
    public GameObject endLvlObj;

     Lvl1UIManager uiScript;

    private void Start()
    {
        uiScript = uiObj.GetComponent<Lvl1UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player")) 
        {
            hasTriggered = true; 

            foreach (GameObject item in itemsToToggle)
            {
                if (item != null)
                {
                    item.SetActive(!item.activeSelf);
                }
            }

            uiScript.BringUpUI();
            
            if(endLvlObj != null)
            {
                endLvlObj.SetActive(true);
            }

        }
    }
}


