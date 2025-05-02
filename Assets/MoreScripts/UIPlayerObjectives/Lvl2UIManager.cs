using TMPro;
using UnityEngine;

public class Lvl2UIManager : MonoBehaviour
{
    public TextMeshProUGUI grappleText;
    public TextMeshProUGUI goLibraryText;
    public TextMeshProUGUI findBooksText;
    public TextMeshProUGUI finalText;


    public void UIUpdateLib()
    {
        grappleText.gameObject.SetActive(false);
        goLibraryText.gameObject.SetActive(true);  
    }

    public void UIUpdateBooks()
    {
        goLibraryText.gameObject.SetActive(false);
        findBooksText.gameObject.SetActive(true);
    }

    public void UIUpdateFinal()
    {
        findBooksText.gameObject.SetActive(false);
        finalText.gameObject.SetActive(true);
    }

}


