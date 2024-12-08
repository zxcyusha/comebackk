using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sad : MonoBehaviour
{
    private bool b = false;
    private bool c = false;
    private bool e = false;
    private bool f = false;
    private bool j = false;
    private bool yellow = false;
    private bool fiol = false;
    private bool pink = false;
    public bool red = false;
    public GameObject grabli;
    public GameObject grabl;
    public GameObject gradka1;
    public GameObject gradka2;
    public GameObject gradka3;
    public GameObject gradka4;
    public GameObject gradka5;
    public GameObject gradka6;
    public GameObject gradka11;
    public GameObject gradka22;
    public GameObject gradka33;
    public GameObject gradka44;
    public GameObject gradka55;
    public GameObject gradka66;
    public GameObject leikale;
    public GameObject leikar;
    public GameObject water;
    public GameObject textic;
    public GameObject TextPropAndPol;
    public GameObject TextPoley;
    public GameObject PaketVRucah;
    public GameObject PaketSAnim;
    public GameObject seed1;
    public GameObject seed2;
    public GameObject seed3;
    public GameObject seed4;
    public GameObject seed5;
    public GameObject seed6;
    public GameObject trava;
    public GameObject flower;
    public Animator animat1;
    public Animator animat2;
    public Animator animat3;
    public Animator animat4;
    public Animator animat5;
    public GameObject pcela1;
    public GameObject pcela2;
    public GameObject pcela3;
    public GameObject pcela4;
    public GameObject pcela5;
    public TMPro.TMP_Text HP;
    public GameObject panel1;
    public GameObject back1;
    public GameObject zavavshiecv1;
    public GameObject zavavshiecv2;
    public GameObject zavavshiecv3;
    public GameObject zavavshiecv4;
    public GameObject zavavshiecv5;
    public GameObject zavavshiecv6;
    public GameObject lopataVRuk;
    public GameObject lopataAnim;
    public GameObject flow1;
    public GameObject flow2;
    public GameObject flow3;
    public GameObject flow4;
    public GameObject flow5;
    public GameObject flow6;
    public GameObject paketYelVRuk;
    public GameObject paket2;
    public GameObject peketYelAnim;
    public GameObject yellowFlowers1;
    public GameObject yellowFlowers2;
    public GameObject yellowFlowers3;
    public GameObject yellowFlowers4;
    public GameObject yellowFlowers5;
    public GameObject yellowFlowers6;
    public GameObject rose1;
    public GameObject rose2;
    public GameObject rose3;
    public GameObject rose4;
    public GameObject rose5;
    public GameObject rose6;
    public GameObject paket3;
    public GameObject paket3Anim;
    public GameObject fiolPak;
    public GameObject fiolAnim;
    public GameObject pinkPak;
    public GameObject pinkAnim;
    public GameObject fiolCv1;
    public GameObject fiolCv2;
    public GameObject fiolCv3;
    public GameObject fiolCv4;
    public GameObject fiolCv5;
    public GameObject fiolCv6;
    public GameObject pinkCv1;
    public GameObject pinkCv2;
    public GameObject pinkCv3;
    public GameObject pinkCv4;
    public GameObject pinkCv5;
    public GameObject pinkCv6;
    private bool peremenna = false;
    public bool aga = false;
    public bool zveti = false;
    private bool per = true;
    public static bool newflowers = false;
    public static int hp = 0;
    public bool zveti1 = false;
    private bool zveti2 = false;
    private bool zveti3 = false;
    private bool zveti4 = false;
    public static bool posadili = false;
    
    void Start() {
        animat1 = pcela1.GetComponent<Animator>();
        animat2 = pcela2.GetComponent<Animator>();
        animat3 = pcela3.GetComponent<Animator>();
        animat4 = pcela4.GetComponent<Animator>();
        animat5 = pcela5.GetComponent<Animator>();
        back1.GetComponent<Button>().onClick.AddListener(delegate { zacr(); });
    }
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "sad") {
            b = true;
        }
        if (other.gameObject.tag == "grabla") {
            c = true;
        }
        if (other.gameObject.tag == "leika") {
            e = true;
        }
        if (other.gameObject.tag == "paketic") {
            f = true;
        }
        if (other.gameObject.tag == "lopata") {
            j = true;
        }
        if (other.gameObject.tag == "paket") {
            yellow = true;
        }
        if (other.gameObject.tag == "pacetishe") {
            red = true;
        }
        if (other.gameObject.tag == "paketFiol") {
            fiol = true;
        }
        if (other.gameObject.tag == "paketPose") {
            pink = true;
        }
    }
    void OnTriggerExit(Collider other) {
        b = false;
        c = false;
        e = false;
        f = false;
        j = false;
        fiol = false;
        pink = false;
        yellow = false;
        red = false;
        textic.SetActive(false);
        TextPropAndPol.SetActive(false);
    }
    void Update()
    {
        HP.text = hp.ToString();
        if (b == true && Input.GetKeyDown(KeyCode.C) && c == true) {
            grabli.SetActive(true);
            grabl.SetActive(false);
            Invoke("one", 0.4f);
            Invoke("two", 1.11f);
            Invoke("three", 2f);
            Invoke("fore", 3.38f);
            Invoke("five", 4.15f);
            Invoke("six", 5f);
            Invoke("ii", 5f);
            peremenna = true;
            posadili = true;
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && e == true && peremenna == true) {
            leikale.SetActive(true);
            leikar.SetActive(false);
            Invoke("onee", 0.22f);
            Invoke("twoo", 0.45f);
            Invoke("threee", 1.11f);
            Invoke("wateroff", 1.25f);
            Invoke("wateron", 2.4f);
            Invoke("foree", 3.05f);
            Invoke("fivee", 3.27f);
            Invoke("sixx", 3.57f);
            Invoke("iii", 3.57f);
            aga = true;
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && zveti == false && newflowers == true && yellow == true && aga == true) {
            paketYelVRuk.SetActive(false);
            peketYelAnim.SetActive(true);
            Invoke("sekret1", 9.21f);
            Invoke("semena1", 0.36f);
            Invoke("semena2", 2.18f);
            Invoke("semena3", 3.35f);
            Invoke("semena4", 4.58f);
            Invoke("semena5", 6.51f);
            Invoke("semena6", 8.47f);
            Invoke("travka1", 20f);
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && zveti == false && zveti1 == false && newflowers == true && red == true && aga == true) { 
            paket3.SetActive(false);
            paket3Anim.SetActive(true);
            Invoke("sekret2", 9.21f);
            Invoke("semena1", 0.36f);
            Invoke("semena2", 2.18f);
            Invoke("semena3", 3.35f);
            Invoke("semena4", 4.58f);
            Invoke("semena5", 6.51f);
            Invoke("semena6", 8.47f);
            Invoke("travka2", 20f);
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && zveti == false && zveti1 == false && zveti2 == false && fiol == true && aga == true) {
            fiolPak.SetActive(false);
            fiolAnim.SetActive(true);
            Invoke("sekret3", 9.21f);
            Invoke("semena1", 0.36f);
            Invoke("semena2", 2.18f);
            Invoke("semena3", 3.35f);
            Invoke("semena4", 4.58f);
            Invoke("semena5", 6.51f);
            Invoke("semena6", 8.47f);
            Invoke("travka3", 20f);
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && zveti == false && zveti1 == false && zveti2 == false && zveti3 == false && pink == true && aga == true) {
            pinkPak.SetActive(false);
            pinkAnim.SetActive(true);
            Invoke("sekret4", 9.21f);
            Invoke("semena1", 0.36f);
            Invoke("semena2", 2.18f);
            Invoke("semena3", 3.35f);
            Invoke("semena4", 4.58f);
            Invoke("semena5", 6.51f);
            Invoke("semena6", 8.47f);
            Invoke("travka4", 20f);
        }

        if (b == true && Input.GetKeyDown(KeyCode.C) && e == true && peremenna == false) {
            textic.SetActive(true);
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && f == true && peremenna == false) {
            TextPropAndPol.SetActive(true);
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && f == true && peremenna == true && aga == false) {
            TextPoley.SetActive(true);
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && f == true && aga == true) {
            PaketVRucah.SetActive(false);
            PaketSAnim.SetActive(true);
            Invoke("sekret", 9.21f);
            Invoke("semena1", 0.36f);
            Invoke("semena2", 2.18f);
            Invoke("semena3", 3.35f);
            Invoke("semena4", 4.58f);
            Invoke("semena5", 6.51f);
            Invoke("semena6", 8.47f);
            Invoke("travka", 20f);
        }
        if (b == true && per == false && Input.GetKeyDown(KeyCode.C) && j == true) {
            lopataVRuk.SetActive(false);
            lopataAnim.SetActive(true);
            Invoke("Cv1", 0.42f);
            Invoke("Cv2", 3.04f);
            Invoke("Cv3", 5.23f);
            Invoke("Cv4", 8.09f);
            Invoke("Cv5", 10.5f);
            Invoke("Cv6", 13.32f);
            Invoke("End", 14.16f);
            zveti = false;
        }
        if (b == true && zveti == true && Input.GetKeyDown(KeyCode.C) && j == true) {
            lopataVRuk.SetActive(false);
            lopataAnim.SetActive(true);
            Invoke("Del1", 0.42f);
            Invoke("Del2", 3.04f);
            Invoke("Del3", 5.23f);
            Invoke("Del4", 8.09f);
            Invoke("Del5", 10.5f);
            Invoke("Del6", 13.32f);
            Invoke("End", 14.16f);
            zveti = false;
        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && j == true && zveti1 == true) {
            lopataVRuk.SetActive(false);
            lopataAnim.SetActive(true);
            Invoke("Del11", 0.42f);
            Invoke("Del22", 3.04f);
            Invoke("Del33", 5.23f);
            Invoke("Del44", 8.09f);
            Invoke("Del55", 10.5f);
            Invoke("Del66", 13.32f);
            Invoke("End", 14.16f);
            zveti1 = false;

        }
        if (b == true && Input.GetKeyDown(KeyCode.C) && j == true && zveti2 == true) {
            lopataVRuk.SetActive(false);
            lopataAnim.SetActive(true);
            Invoke("Del111", 0.42f);
            Invoke("Del222", 3.04f);
            Invoke("Del333", 5.23f);
            Invoke("Del444", 8.09f);
            Invoke("Del555", 10.5f);
            Invoke("Del666", 13.32f);
            Invoke("End", 14.16f);
            zveti1 = false;

        }
    }
    void ii() {
        grabli.SetActive(false);
        grabl.SetActive(true);
    }
    void one() {
        gradka1.SetActive(true);
    }
    void two() {
        gradka2.SetActive(true);
    }
    void three() {
        gradka3.SetActive(true);
    }
    void fore() {
        gradka4.SetActive(true);
    }
    void five() {
        gradka5.SetActive(true);
    }
    void six() {
        gradka6.SetActive(true);
    }

    void iii() {
        leikale.SetActive(false);
        leikar.SetActive(true);
    }
    void onee() {
        gradka11.SetActive(true);
    }
    void twoo() {
        gradka22.SetActive(true);
    }
    void threee() {
        gradka33.SetActive(true);
    }
    void foree() {
        gradka44.SetActive(true);
    }
    void fivee() {
        gradka55.SetActive(true);
    }
    void sixx() {
        gradka66.SetActive(true);
    }
    void wateroff() {
        water.SetActive(false);
    }
    void wateron() {
        water.SetActive(true);
    }
    void sekret() {
        PaketVRucah.SetActive(true);
        PaketSAnim.SetActive(false);
    }
    void sekret1() {
        paketYelVRuk.SetActive(true);
        peketYelAnim.SetActive(false);
    }
    void sekret2() {
        paket3.SetActive(true);
        paket3Anim.SetActive(false);
    }
    void sekret3() {
        fiolPak.SetActive(true);
        fiolAnim.SetActive(false);
    }
    void sekret4() {
        pinkPak.SetActive(true);
        pinkAnim.SetActive(false);
    }
    void semena1() {
        seed1.SetActive(true);
        posadili = true;
        Таймер.sec = 0;
    }
    void semena2() {
        seed2.SetActive(true);
    }
    void semena3() {
        seed3.SetActive(true);
    }
    void semena4() {
        seed4.SetActive(true);
    }
    void semena5() {
        seed5.SetActive(true);
    }
    void semena6() {
        seed6.SetActive(true);
    }
    
    void travka() {
        trava.SetActive(true);
        seed1.SetActive(false);
        seed2.SetActive(false);
        seed3.SetActive(false);
        seed4.SetActive(false);
        seed5.SetActive(false);
        seed6.SetActive(false);
        Invoke("flowers", 10f);
        zveti = true;
    }
    void travka1() {
        trava.SetActive(true);
        seed1.SetActive(false);
        seed2.SetActive(false);
        seed3.SetActive(false);
        seed4.SetActive(false);
        seed5.SetActive(false);
        seed6.SetActive(false);
        zveti1 = true;
        Invoke("flowers1", 10f);
    }
    void travka2() {
        trava.SetActive(true);
        seed1.SetActive(false);
        seed2.SetActive(false);
        seed3.SetActive(false);
        seed4.SetActive(false);
        seed5.SetActive(false);
        seed6.SetActive(false);
        zveti2 = true;
        Invoke("flowers2", 10f);
    }
    void travka3() {
        trava.SetActive(true);
        seed1.SetActive(false);
        seed2.SetActive(false);
        seed3.SetActive(false);
        seed4.SetActive(false);
        seed5.SetActive(false);
        seed6.SetActive(false);
        zveti3 = true;
        Invoke("flowers3", 10f);
    }
    void travka4() {
        trava.SetActive(true);
        seed1.SetActive(false);
        seed2.SetActive(false);
        seed3.SetActive(false);
        seed4.SetActive(false);
        seed5.SetActive(false);
        seed6.SetActive(false);
        zveti4 = true;
        Invoke("flowers4", 10f);
    }
    void flowers() {
        if (zveti == true) {
        trava.SetActive(false);
        flower.SetActive(true);
        animat1.SetTrigger("first");
        animat2.SetTrigger("second");
        animat3.SetTrigger("third");
        animat4.SetTrigger("fourth");
        animat5.SetTrigger("fiveth");
        Invoke("weed", 100f);
        panel1.SetActive(true);
        Invoke("med", 30f);
        }
    }
    void flowers1() {
        if (zveti1 == true) {
        trava.SetActive(false);
        yellowFlowers1.SetActive(true);
        yellowFlowers2.SetActive(true);
        yellowFlowers3.SetActive(true);
        yellowFlowers4.SetActive(true);
        yellowFlowers5.SetActive(true);
        yellowFlowers6.SetActive(true);
        animat1.SetTrigger("first");
        animat2.SetTrigger("second");
        animat3.SetTrigger("third");
        animat4.SetTrigger("fourth");
        animat5.SetTrigger("fiveth");
        Invoke("weed1", 120f);
        Invoke("med1", 30f);
        }
    }
    void flowers2() {
        if (zveti2 == true) {
        trava.SetActive(false);
        rose1.SetActive(true);
        rose2.SetActive(true);
        rose3.SetActive(true);
        rose4.SetActive(true);
        rose5.SetActive(true);
        rose6.SetActive(true);
        animat1.SetTrigger("first");
        animat2.SetTrigger("second");
        animat3.SetTrigger("third");
        animat4.SetTrigger("fourth");
        animat5.SetTrigger("fiveth");
        Invoke("weed2", 140f);
        Invoke("med2", 30f);
        }
    }
    void flowers3() {
        if (zveti3 == true) {
        trava.SetActive(false);
        fiolCv1.SetActive(true);
        fiolCv2.SetActive(true);
        fiolCv3.SetActive(true);
        fiolCv4.SetActive(true);
        fiolCv5.SetActive(true);
        fiolCv6.SetActive(true);
        animat1.SetTrigger("first");
        animat2.SetTrigger("second");
        animat3.SetTrigger("third");
        animat4.SetTrigger("fourth");
        animat5.SetTrigger("fiveth");
        Invoke("weed3", 160f);
        Invoke("med3", 30f);
        }
    }
    void flowers4() {
        if (zveti4 == true) {
        trava.SetActive(false);
        pinkCv1.SetActive(true);
        pinkCv2.SetActive(true);
        pinkCv3.SetActive(true);
        pinkCv4.SetActive(true);
        pinkCv5.SetActive(true);
        pinkCv6.SetActive(true);
        animat1.SetTrigger("first");
        animat2.SetTrigger("second");
        animat3.SetTrigger("third");
        animat4.SetTrigger("fourth");
        animat5.SetTrigger("fiveth");
        Invoke("weed4", 160f);
        Invoke("med4", 30f);
        }
    }
    void med() {
        if (zveti == true) {
        hp++;
        HP.text = hp.ToString();
        Invoke("med", 10f);
        }
    }
    void med1() {
        if (zveti1 == true) {
        hp += 2;
        HP.text = hp.ToString();
        Invoke("med1", 10f);
        }
    }
    void med2() {
        if (zveti2 == true) {
        hp += 5;
        HP.text = hp.ToString();
        Invoke("med2", 10f);
        }
    }
    void med3() {
        if (zveti3 == true) {
        hp += 10;
        HP.text = hp.ToString();
        Invoke("med3", 10f);
        }
    }
    void med4() {
        if (zveti4 == true) {
        hp += 13;
        HP.text = hp.ToString();
        Invoke("med4", 10f);
        }
    }
    void zacr() {
        panel1.SetActive(false);
        newflowers = true;
        paketYelVRuk.SetActive(true);
        paket2.SetActive(true);
        paket3.SetActive(true);
    }
    void weed() {
        if (zveti == true) {
        flower.SetActive(false);
        zavavshiecv1.SetActive(true);
        zavavshiecv2.SetActive(true);
        zavavshiecv3.SetActive(true);
        zavavshiecv4.SetActive(true);
        zavavshiecv5.SetActive(true);
        zavavshiecv6.SetActive(true);
        zveti = false;
        per = false;
        }
    }
    void weed1() {
        if (zveti1 == true) {
        yellowFlowers1.SetActive(false);
        yellowFlowers2.SetActive(false);
        yellowFlowers3.SetActive(false);
        yellowFlowers4.SetActive(false);
        yellowFlowers5.SetActive(false);
        yellowFlowers6.SetActive(false);
        zavavshiecv1.SetActive(true);
        zavavshiecv2.SetActive(true);
        zavavshiecv3.SetActive(true);
        zavavshiecv4.SetActive(true);
        zavavshiecv5.SetActive(true);
        zavavshiecv6.SetActive(true);
        zveti1 = false;
        per = false;
        }
    }
    void weed2() {
        if (zveti2 == true) {
        rose1.SetActive(false);
        rose2.SetActive(false);
        rose3.SetActive(false);
        rose4.SetActive(false);
        rose5.SetActive(false);
        rose6.SetActive(false);
        zavavshiecv1.SetActive(true);
        zavavshiecv2.SetActive(true);
        zavavshiecv3.SetActive(true);
        zavavshiecv4.SetActive(true);
        zavavshiecv5.SetActive(true);
        zavavshiecv6.SetActive(true);
        zveti2 = false;
        per = false;
        }
    }
    void weed3() {
        if (zveti3 == true) {
        fiolCv1.SetActive(false);
        fiolCv2.SetActive(false);
        fiolCv3.SetActive(false);
        fiolCv4.SetActive(false);
        fiolCv5.SetActive(false);
        fiolCv6.SetActive(false);
        zavavshiecv1.SetActive(true);
        zavavshiecv2.SetActive(true);
        zavavshiecv3.SetActive(true);
        zavavshiecv4.SetActive(true);
        zavavshiecv5.SetActive(true);
        zavavshiecv6.SetActive(true);
        zveti3 = false;
        per = false;
        }
    }
    void weed4() {
        if (zveti4 == true) {
        pinkCv1.SetActive(false);
        pinkCv2.SetActive(false);
        pinkCv3.SetActive(false);
        pinkCv4.SetActive(false);
        pinkCv5.SetActive(false);
        pinkCv6.SetActive(false);
        zavavshiecv1.SetActive(true);
        zavavshiecv2.SetActive(true);
        zavavshiecv3.SetActive(true);
        zavavshiecv4.SetActive(true);
        zavavshiecv5.SetActive(true);
        zavavshiecv6.SetActive(true);
        zveti4 = false;
        per = false;
        }
    }

    void Cv1() {
        zavavshiecv1.SetActive(false);   
    }
    void Cv2() {
        zavavshiecv2.SetActive(false);
    }
    void Cv3() {
        zavavshiecv3.SetActive(false);
    }
    void Cv4() {
        zavavshiecv4.SetActive(false);
    }
    void Cv5() {
        zavavshiecv5.SetActive(false);
    }
    void Cv6() {
        zavavshiecv6.SetActive(false);
    }
    void End() {
        lopataAnim.SetActive(false);
        lopataVRuk.SetActive(true);
        gradka1.SetActive(false);
        gradka2.SetActive(false);
        gradka3.SetActive(false);
        gradka4.SetActive(false);
        gradka5.SetActive(false);
        gradka6.SetActive(false);
        gradka11.SetActive(false);
        gradka22.SetActive(false);
        gradka33.SetActive(false);
        gradka44.SetActive(false);
        gradka55.SetActive(false);
        gradka66.SetActive(false);
        peremenna = false;
        aga = false;
    }
    void Del1() {
        flow1.SetActive(false);
    }
    void Del2() {
        flow2.SetActive(false);
    }
    void Del3() {
        flow3.SetActive(false);
    }
    void Del4() {
        flow4.SetActive(false);
    }
    void Del5() {
        flow5.SetActive(false);
    }
    void Del6() {
        flow6.SetActive(false);
    }
    void Del11() {
        yellowFlowers1.SetActive(false);
    }
    void Del22() {
        yellowFlowers2.SetActive(false);
    }
    void Del33() {
        yellowFlowers3.SetActive(false);
    }
    void Del44() {
        yellowFlowers4.SetActive(false);
    }
    void Del55() {
        yellowFlowers5.SetActive(false);
    }
    void Del66() {
        yellowFlowers6.SetActive(false);
    }
    void Del111() {
        rose1.SetActive(false);
    }
    void Del222() {
        rose2.SetActive(false);
    }
    void Del333() {
        rose3.SetActive(false);
    }
    void Del444() {
        rose4.SetActive(false);
    }
    void Del555() {
        rose5.SetActive(false);
    }
    void Del666() {
        rose6.SetActive(false);
    }
}
