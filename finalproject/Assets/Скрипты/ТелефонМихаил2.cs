using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ТелефонМихаил2 : MonoBehaviour
{
    public GameObject bortcomp;
    public GameObject micail;
    public GameObject oskar;
    public GameObject phoneWithout;
    public GameObject phoneWith;
    public AudioSource uvedoml;
    public GameObject scroll2;
    public GameObject scroll3;
    public GameObject imagee;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject scroll4;
    public GameObject imageee;
    bool ready = false;
    public Sprite firstdontright;
    public Sprite dontrightanswer;
    public static bool anssecond = false;

    void Start() {
        answer1.GetComponent<Button>().onClick.AddListener(delegate { otvetNEright(); });
        answer2.GetComponent<Button>().onClick.AddListener(delegate { otvetright(); });
    }

    void Update()
    {
        if (ТелефонсМихаилом.end == true && ready == false) {
        Invoke("SMS", 30f);
        ready = true;
        }
    }

    void SMS() {
        bortcomp.SetActive(false);
        micail.SetActive(true);
        oskar.SetActive(false);
        uvedoml.Play();
        phoneWith.SetActive(true);
        phoneWithout.SetActive(false);
        scroll2.SetActive(false);
        scroll3.SetActive(true);
        if (ТелефонсМихаилом.firstright == false) {
            imagee.GetComponent<Image>().sprite = firstdontright;
        } 
    }
    void otvetright() {
        scroll3.SetActive(false);
        scroll4.SetActive(true);
        anssecond = true;
    }
    void otvetNEright() {
        scroll3.SetActive(false);
        scroll4.SetActive(true);
        imageee.GetComponent<Image>().sprite = dontrightanswer;
    }
}
