using UnityEngine;

public class UIGoLibrary : MonoBehaviour
{
    public GameObject uiObj;
    Lvl2UIManager uiScript;

    private void Start()
    {
        uiScript = uiObj.GetComponent<Lvl2UIManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiScript.UIUpdateLib();

        }
    }
}
