using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public string lvl3Scene = "MainLevel3";

    public static UIlvl3Manager uiScript;
    public GameObject uiObj;

    public static Respawn Instance;

    public static Respawn GetInstance()
    {
        return Instance;
    }


    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        uiScript = uiObj.GetComponent<UIlvl3Manager>();
    }


    public void RespawnPlayer()
    {
        uiScript.PlayerCaught();
        Invoke("LoadLvl3", 3);
        
    }

    public void LoadLvl3()
    {
        SceneManager.LoadScene(lvl3Scene);
    }
}
