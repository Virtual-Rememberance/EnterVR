using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel2 : MonoBehaviour
{
    public string level3scene = "MainLevel3";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(level3scene);

        }
    }
}
