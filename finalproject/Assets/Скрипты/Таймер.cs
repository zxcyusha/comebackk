using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Таймер : MonoBehaviour
{
    public static float sec = 0;
    public GameObject predup;
    public GameObject smert;
    public GameObject vmenu;
    public GameObject zastavka;

    void Start() {
        vmenu.GetComponent<Button>().onClick.AddListener(delegate { end(); });
    }
    void Update () {
        sec += 1 * Time.deltaTime;
        int intValue = (int)sec;
        Debug.Log(intValue);
        if (intValue == 200 && Sad.posadili == false) {
            predup.SetActive(true);
            Invoke("zacr", 4f);
        }
        if (intValue == 390 && Sad.posadili == false) {
            smert.SetActive(true);
        }
        if (intValue == 200 && Sad.posadili == true) {
            Sad.posadili = false;
        }
    }
    void zacr() {
        predup.SetActive(false);
    }
    void end() {
        zastavka.SetActive(true);
    }
}
