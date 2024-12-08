using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Подсказки : MonoBehaviour
{
    public GameObject panel;
    private bool aga = false;
    public GameObject buck;
    public GameObject text1;
    public GameObject text2;
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        buck.GetComponent<Button>().onClick.AddListener(delegate { back(); });
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "zonapchel" && aga == false) {
            panel.SetActive(true);
            aga = true;
        }
    }
    void back() {
        panel.SetActive(false);
        text1.SetActive(true);
        text2.SetActive(false);

    }
}
