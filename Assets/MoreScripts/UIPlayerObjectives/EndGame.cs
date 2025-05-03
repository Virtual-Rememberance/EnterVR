using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject nopeWall;
    public Collider buttonColl;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Hands"))
        {

            Debug.Log("Hands has entered me");
            endPanel.SetActive(true);
            nopeWall.SetActive(true);
            buttonColl.enabled = false;

        }
        

    }
}
