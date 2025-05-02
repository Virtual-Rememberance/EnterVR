using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class EndGame : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject nopeWall;
    public Collider buttonColl;

    private void OnTriggerEnter(Collider other)
    {
        if (buttonColl != null)
        {
            Debug.Log(" Button collider on!");

            if (other.CompareTag("Hands"))
            {

                Debug.Log("Hands has entered me");
                endPanel.SetActive(true);
                nopeWall.SetActive(true);
                buttonColl.enabled = false;

            }
            else
            {
                Debug.Log(" Those are not hands!!! ");
            }
        }

       

    }
}
