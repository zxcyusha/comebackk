using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class мини : MonoBehaviour
{
    public GameObject panel;
    public GameObject e;
    public GameObject player;
    public GameObject atmospherelevel;
    public GameObject norm;
    public GameObject konzovka;
    public static bool canGame = false;
    bool otcr = false;
    private bool game = false;
    void Start() {
        Invoke("atmosphere", 160f);
        Invoke("atmosphereclose", 164f);
        Invoke("proverka", 220f);
        Invoke("atmosphere", 320f);
        Invoke("atmosphereclose", 323f);
        Invoke("proverka", 380f);
    }
    void Update()
    {
        if (game == true && Input.GetKeyDown(KeyCode.E) && canGame == true) {

            panel.SetActive(true);
            player.SetActive(false);
            otcr = true;
            e.SetActive(false);
        }
        if (game == true && canGame == false) {

            norm.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "mini") {
            game = true;
            if (otcr == false && canGame == true) {
                e.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other) {
        e.SetActive(false);
        game = false;
        player.SetActive(true);
        norm.SetActive(false);
    }
    void atmosphere() {
        atmospherelevel.SetActive(true);
        canGame = true;
    }
    void atmosphereclose() {
        atmospherelevel.SetActive(false);
    }
    void proverka() {
        if (Миниигра.proshel == false) {
            konzovka.SetActive(true);
        }
        else {
            Invoke("sled", 1f);
        }
    }
    void sled() {
        Миниигра.proshel = false;
    }
}
