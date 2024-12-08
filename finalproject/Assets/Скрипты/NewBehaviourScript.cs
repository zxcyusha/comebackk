using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject hren1;
    public GameObject hren2;
    
    public void catcsene()
    {
        hren1.SetActive(true);
        hren2.SetActive(true);
        Invoke("pecluchi", 97f);
    }

    void pecluchi() {
        hren1.SetActive(false);
        hren2.SetActive(false);
    }
}
