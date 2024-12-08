using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ТелефонсМихаилом : MonoBehaviour
{
    public GameObject bortcomp;
    public GameObject micail;
    public GameObject oskar;
    public GameObject telefonwithout;
    public GameObject telefonwith;
    public GameObject imagee;
    public Sprite smska1;
    public AudioSource uvedoml;
    public GameObject butPerecl;
    public Sprite smska2;
    public Sprite smska3;
    public GameObject scrollMic;
    public GameObject scrollMic1;
    public GameObject otvet1;
    public GameObject otvet2;
    public GameObject otvet3;
    public GameObject scrollMic2;
    public GameObject imageee;
    public Sprite right;
    public static bool ending1 = true;
    public static bool firstright = true;
    bool a = false;
    bool can = false;
    public static bool end = false;
    public static bool ansfirst = false;
    int schet = 0;

    void Start()
    {
        butPerecl.GetComponent<Button>().onClick.AddListener(delegate { perecluchi(); });
        otvet1.GetComponent<Button>().onClick.AddListener(delegate { unswer1(); });
        otvet2.GetComponent<Button>().onClick.AddListener(delegate { unswer2(); });
        otvet3.GetComponent<Button>().onClick.AddListener(delegate { unswer1(); });
        Invoke("sms", 190f);
        Invoke("eshesms", 210f);
    }
    void sms() {
        uvedoml.Play();
        telefonwithout.SetActive(false);
        telefonwith.SetActive(true);
        bortcomp.SetActive(false);
        micail.SetActive(true);
        oskar.SetActive(false);
        imagee.GetComponent<Image>().sprite = smska1;
        butPerecl.SetActive(true);
    }
    void perecluchi() {
        if (schet == 0) {
            imagee.GetComponent<Image>().sprite = smska2;
            schet++;
            return;
        }
        if (schet == 1) {
            imagee.GetComponent<Image>().sprite = smska3;
            schet++;
            return;
        }
    }
    void eshesms() {
        telefonwithout.SetActive(false);
        telefonwith.SetActive(true);
        bortcomp.SetActive(false);
        micail.SetActive(true);
        oskar.SetActive(false);
        uvedoml.Play();
        can = true;
    }
    void Update() {
        if (schet == 2 && can == true && a == false) {
            scrollMic.SetActive(false);
            scrollMic1.SetActive(true);
        }
    }
    void unswer1() {
        firstright = false;
        scrollMic.SetActive(false);
        scrollMic1.SetActive(false);
        scrollMic2.SetActive(true);
        a = true;
        end = true;
        ending1 = false;
    }
    void unswer2() {
        scrollMic.SetActive(false);
        scrollMic1.SetActive(false);
        scrollMic2.SetActive(true);
        imageee.GetComponent<Image>().sprite = right;
        a = true;
        end = true;
        ending1 = false;
        ansfirst = true;

    }
}
