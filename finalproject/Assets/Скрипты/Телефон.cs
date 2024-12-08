using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Телефон : MonoBehaviour
{
    public GameObject phone;
    public GameObject bortComp;
    public GameObject Micail;
    public GameObject oskar;
    public GameObject phonewithout;
    public GameObject phonewith;
    public Sprite SMSbort;
    public AudioSource uvedoml;
    public GameObject scrollOsc;
    public Sprite SMSosk1;
    public GameObject perecl;
    public Sprite SMSosk2;
    public Sprite SMSosk3;
    public GameObject scrollOsc1;
    public GameObject unswer1;
    public GameObject unswer2;
    public GameObject panelUns2;
    public GameObject scrollOsc2;
    public GameObject pomenyutimage;
    public Sprite secondAnswer;
    public GameObject knZacr;
    public GameObject poskazka;
    int number = 0;

    void Start() {
        Invoke("SMS1", 130f);
        Invoke("SMS2", 170f);
        perecl.GetComponent<Button>().onClick.AddListener(delegate { perecluchi(); });
        unswer1.GetComponent<Button>().onClick.AddListener(delegate { otvet1(); });
        unswer2.GetComponent<Button>().onClick.AddListener(delegate { otvet2(); });
        knZacr.GetComponent<Button>().onClick.AddListener(delegate { zacrit(); });
    }

    public void open() {
        phone.SetActive(true);
        Time.timeScale = 0f;
    }
    public void close() {
        phone.SetActive(false);
        Time.timeScale = 1f;
    }
    public void bortcomp() {
        bortComp.SetActive(true);
        Micail.SetActive(false);
        oskar.SetActive(false);
    }
    public void miha() {
        bortComp.SetActive(false);
        Micail.SetActive(true);
        oskar.SetActive(false);
    }
    public void Oskar() {
        bortComp.SetActive(false);
        Micail.SetActive(false);
        oskar.SetActive(true);
    }

    void SMS1() {
        uvedoml.Play();
        phonewithout.SetActive(false);
        phonewith.SetActive(true);
        bortComp.GetComponent<Image>().sprite = SMSbort;
        bortComp.SetActive(true);
        Micail.SetActive(false);
        oskar.SetActive(false);
    }
    public void openVith() {
        phone.SetActive(true);
        phonewithout.SetActive(true);
        phonewith.SetActive(false);
        Time.timeScale = 0f;
    }
    public void SMS2() {
        uvedoml.Play();
        phonewithout.SetActive(false);
        phonewith.SetActive(true);
        scrollOsc.GetComponent<Image>().sprite = SMSosk1;
        bortComp.SetActive(false);
        Micail.SetActive(false);
        oskar.SetActive(true);
        perecl.SetActive(true);
        poskazka.SetActive(true);
    }
    void perecluchi() {
        if (number == 0) {
            scrollOsc.GetComponent<Image>().sprite = SMSosk2;
            number++;
            return;
        }
        if (number == 1) {
            scrollOsc.GetComponent<Image>().sprite = SMSosk3;
            number++;
            return;
        }
        if (number == 2) {
            scrollOsc.SetActive(false);
            scrollOsc1.SetActive(true);
        }
    }
    void otvet1() {
        scrollOsc1.SetActive(false);
        scrollOsc2.SetActive(true);
    }
    void otvet2() {
        scrollOsc1.SetActive(false);
        scrollOsc2.SetActive(true);
        pomenyutimage.GetComponent<Image>().sprite = secondAnswer;
    }
    void zacrit() {
        poskazka.SetActive(false);
    }
}
