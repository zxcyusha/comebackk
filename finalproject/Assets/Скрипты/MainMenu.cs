using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    public GameObject game;
    public GameObject panel;
    public GameObject Exit;
    public AudioSource zvuk1;
    public AudioSource zvuk2;
    public GameObject pann;
    public GameObject vvod;
    public Transform player;
    public Rigidbody rb;
    private bool nooo = false;
    private bool kat = false;
    public TMPro.TMP_Text HP;
    public TMPro.TMP_Text HPkrist;
    public GameObject krist1;
    public GameObject krist2;
    public GameObject krist3;
    public GameObject krist4;
    public GameObject krist5;
    public GameObject krist6;
    public GameObject krist7;
    public GameObject krist8;
    public GameObject krist9;
    public GameObject krist10;
    void Start() {
        Exit.GetComponent<Button>().onClick.AddListener(delegate { ExitGame(); });
    }
    public void LoadLevel()
    {
        int hpp = 0;
        int krict = 0;
        panel.SetActive(false);
        zvuk1.Stop();
        zvuk2.Play();
        if (nooo == false) {
            pann.SetActive(true);
            vvod.SetActive(true);
            nooo = true;
        }
        rb.isKinematic = true;
        player.position = new Vector3(0.53f,3.734f,36.52f);
        Invoke("vcl", 1f);
        HP.text = hpp.ToString();
        HPkrist.text = krict.ToString();
        krist1.SetActive(true);
        krist2.SetActive(true);
        krist3.SetActive(true);
        krist4.SetActive(true);
        krist5.SetActive(true);
        krist6.SetActive(true);
        krist7.SetActive(true);
        krist8.SetActive(true);
        krist9.SetActive(true);
        krist10.SetActive(true);
    }
    void vcl() {
        rb.isKinematic = false;
    }



    public void ExitGame()
    {
        Application.Quit();
    }
}
