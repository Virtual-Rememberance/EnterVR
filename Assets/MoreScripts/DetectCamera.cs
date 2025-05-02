using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class DetectCamera : MonoBehaviour
{
   // [SerializeField]private TextMeshProUGUI caughtText;
    private bool caughtDisplayed;
    //private int caughtCount;
    private bool caught;



    private void Start()
    {
        //caughtText.enabled = false;
        //caughtCount = 0;
        caught = false;
    }

    private void Update()
    {
            if (caught)
            {
                 Respawn.GetInstance().RespawnPlayer();

            }  
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Camera") && !caught)
        {
            Debug.Log("Caught");
            //StartCoroutine(Caught());
            caught = true;
        }
    }

   

   /* IEnumerator Caught()
    {
        while (caughtCount < 5)
        {
            caughtText.enabled = true;
            yield return new WaitForSeconds(0.75f);
            caughtText.enabled = false;
            yield return new WaitForSeconds(0.75f);
            caughtCount++;
        }
    } */
}
