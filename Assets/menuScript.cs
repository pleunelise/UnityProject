using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{
    public Canvas quitMenu;
    public Button nachtText;
    public Button dagText;



    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas> ();
        nachtText = nachtText.GetComponent<Button> ();
        dagText = dagText.GetComponent<Button>();
    }

    public void StartLevel()
    {
        Application.LoadLevel(2);
    }
}
