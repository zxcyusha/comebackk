using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Паузаа : MonoBehaviour
{
    public GameObject Pause; //
    public GameObject butback;
    public GameObject vmenubut;
    public GameObject player;
    public GameObject comera;
    public GameObject panel;
    public AudioSource Old;
    public AudioSource New;
    public GameObject vkl;
    public GameObject vicl;
    public GameObject about;
    public GameObject panelaboutflowers;
    public GameObject nazad;
    public GameObject magazBut;
    public GameObject magazin;
    public GameObject nazadBut;
    public GameObject zvetosher;
    public GameObject magaz2;
    public GameObject chel;
    public GameObject zad;
    public GameObject settings;
    private bool music = true;
    void Start()
    {
        player.SetActive(true);
        comera.SetActive(true);
        butback.GetComponent<Button>().onClick.AddListener(delegate { back(); });
        vmenubut.GetComponent<Button>().onClick.AddListener(delegate { vmenu(); });
        vkl.GetComponent<Button>().onClick.AddListener(delegate { cwitchon(); });
        vicl.GetComponent<Button>().onClick.AddListener(delegate { cwitchoff(); });
        about.GetComponent<Button>().onClick.AddListener(delegate { aboutflowers(); });
        nazad.GetComponent<Button>().onClick.AddListener(delegate {vernis(); });
        magazBut.GetComponent<Button>().onClick.AddListener(delegate {inmagaz(); });
        nazadBut.GetComponent<Button>().onClick.AddListener(delegate {vern(); });
        zvetosher.GetComponent<Button>().onClick.AddListener(delegate {flora(); });
        chel.GetComponent<Button>().onClick.AddListener(delegate {people(); });
        zad.GetComponent<Button>().onClick.AddListener(delegate {nazadd(); });
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause.SetActive(true);
            //Player.SetActive(false);
            Time.timeScale = 0f;
        }
    }
    void back() {
        Pause.SetActive(false);
        if (music == true) {
            New.Play();
        }
        Old.Stop();
        //Player.SetActive(true);
        Time.timeScale = 1f;
    }
    void vmenu() {
        panel.SetActive(true);
        Old.Play();
        New.Stop();
    }
    void cwitchoff() {
        music = false;
        vicl.SetActive(false);
        vkl.SetActive(true);
        New.Stop();
    }
    void cwitchon() {
        music = true;
        vicl.SetActive(true);
        vkl.SetActive(false);
        New.Play();
    }
    void aboutflowers() {
        panelaboutflowers.SetActive(true);
    }
    void vernis() {
        panelaboutflowers.SetActive(false);
    }
    void inmagaz() {
        magazin.SetActive(true);
    }
    void vern() {
        magazin.SetActive(false);
    }
    void flora() {
        magaz2.SetActive(true);
    }
    void people() {
        magaz2.SetActive(false);
    }
    void nazadd() {
        magaz2.SetActive(false);
        magazin.SetActive(false);
    }
    public void pereidi() {
        settings.SetActive(true);
    }
}
