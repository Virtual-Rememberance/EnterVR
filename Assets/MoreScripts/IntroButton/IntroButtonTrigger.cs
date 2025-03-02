using UnityEngine;

public class IntroButtonTrigger : MonoBehaviour
{
   public BoxCollider buttonColl;
   public AudioClip introClip;
    public void OnTriggerEnter(Collider other)
    {
        if (buttonColl != null)
        {
            if (other.CompareTag("Hands"))
            {
                Debug.Log("Hands has entered me");
                //play audio for intro
                buttonColl.enabled = false;

            }
        }
        
    }
}
