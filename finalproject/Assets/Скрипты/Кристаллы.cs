using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class Кристаллы : MonoBehaviour
{
    static public string mus2_copy = "14831482842821434284";
    static public string mus2 = "14831482842821434284";
    public GameObject kristal1;
    public GameObject kristal2;
    public GameObject kristal3;
    public GameObject kristal4;
    public GameObject kristal5;
    public GameObject kristal6;
    public GameObject kristal7;
    public GameObject kristal8;
    public GameObject kristal9;
    public GameObject kristal10;
    public TMPro.TMP_Text HP;
    public TMPro.TMP_Text HP1;
    public TMPro.TMP_Text HP2;
    public GameObject BearBut;
    public GameObject shlyupa;
    public GameObject ysi;
    public bool police = false;
    public bool fiolet = false;
    public bool rose = false;
    public GameObject fiolBut;
    public GameObject rozBut;
    public GameObject fiolPak;
    public GameObject rozPak;
    public GameObject geting;
    public GameObject gettingFiol;
    public GameObject gettingRose;
    

    public static int hp = 0;
    public static ulong shop_crystalls = 0;
    private bool kris1 = false;
    private bool kris2 = false;
    private bool kris3 = false;
    private bool kris4 = false;
    private bool kris5 = false;
    private bool kris6 = false;
    private bool kris7 = false;
    private bool kris8 = false;
    private bool kris9 = false;
    private bool kris10 = false;
    private int copy = 0;
    private Web_api_functions web_api_functions_object = new Web_api_functions();

    void Start() {
        BearBut.GetComponent<Button>().onClick.AddListener(delegate { shop(); });
        fiolBut.GetComponent<Button>().onClick.AddListener(delegate { fiolget(); });
        rozBut.GetComponent<Button>().onClick.AddListener(delegate { rozget(); });
    }

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "krisall1") {
            kris1 = true;
        }
        if (other.gameObject.tag == "krisall2") {
            kris2 = true;
        }
        if (other.gameObject.tag == "krisall3") {
            kris3 = true;
        }
        if (other.gameObject.tag == "krisall4") {
            kris4 = true;
        }
        if (other.gameObject.tag == "krisall5") {
            kris5 = true;
        }
        if (other.gameObject.tag == "krisall6") {
            kris6 = true;
        }
        if (other.gameObject.tag == "krisall7") {
            kris7 = true;
        }
        if (other.gameObject.tag == "krisall8") {
            kris8 = true;
        }
        if (other.gameObject.tag == "krisall9") {
            kris9 = true;
        }
        if (other.gameObject.tag == "krisall10") {
            kris10 = true;
        }
    }
    void OnTriggerExit(Collider other) {
        kris1 = false;
        kris2 = false;
        kris3 = false;
        kris4 = false;
        kris5 = false;
        kris6 = false;
        kris7 = false;
        kris8 = false;
        kris9 = false;
        kris10 = false;
    }
    void Update()
    {
        HP1.text = hp.ToString();
        HP2.text = hp.ToString();
        if (Input.GetKeyDown(KeyCode.E) && kris1 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris1 = false;
            Destroy(kristal1);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris2 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris2 = false;
            Destroy(kristal2);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris3 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris3 = false;
            Destroy(kristal3);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris4 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris4 = false;
            Destroy(kristal4);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris5 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris5 = false;
            Destroy(kristal5);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris6 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris6 = false;
            Destroy(kristal6);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris7 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris7 = false;
            Destroy(kristal7);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris8 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris8 = false;
            Destroy(kristal8);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris9 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris9 = false;
            Destroy(kristal9);
        }
        if (Input.GetKeyDown(KeyCode.E) && kris10 == true) {
            hp++;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) - 1);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "+1", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            //Player.krist = hp;
            HP.text = hp.ToString();
            HP1.text = hp.ToString();
            HP2.text = hp.ToString();
            kris10 = false;
            Destroy(kristal10);
        }
    }
    void shop() {
        if (hp >= 5 && police == false) 
        {
            copy = hp;
            hp -= 5;
            shop_crystalls += 5;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) + 5);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
                    {
                        if (!operation_status)
                        {
                            Debug.Log("Unexpected error");
                        }
                    }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_changing_shop_resources(player_name: NameInput.Name, shop_name: NameInput.shop_name, honey_amount: 0, crystals_amount: shop_crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought police.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "-5", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_shop_log("Shop selled police.", player_name: NameInput.Name, shop_name: NameInput.shop_name, honey_amount: "0", crystals_amount: "+5", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            HP.text = hp.ToString();
            HP1.text = copy.ToString();
            HP2.text = copy.ToString();
            shlyupa.SetActive(true);
            ysi.SetActive(true);
            police = true;
            geting.SetActive(true);
        }
    }
    void fiolget() {
        if (hp >= 2 && fiolet == false) {
            copy = hp;
            fiolPak.SetActive(true); 
            hp-= 2;
            shop_crystalls += 2;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) + 2);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
                    {
                        if (!operation_status)
                        {
                            Debug.Log("Unexpected error");
                        }
                    }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_changing_shop_resources(player_name: NameInput.Name, shop_name: NameInput.shop_name, honey_amount: 0, crystals_amount: shop_crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought fiolet.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "-2", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_shop_log("Shop selled fiolet.", player_name: NameInput.Name, shop_name: NameInput.shop_name, honey_amount: "0", crystals_amount: "+2", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            HP.text = hp.ToString();
            HP1.text = copy.ToString();
            HP2.text = copy.ToString();
            fiolet = true;
            gettingFiol.SetActive(true);
        }
    }
    void rozget() {
        if (hp >= 3 && rose == false) {
            copy = hp;
            rozPak.SetActive(true); 
            hp -= 3;
            shop_crystalls += 3;
            пополнениемёда.mus1 = Convert.ToString(Convert.ToUInt64(пополнениемёда.mus1) + 3);
            ulong honey = Convert.ToUInt64(пополнениемёда.hpp);
            ulong crystalls = Convert.ToUInt64(hp);
            if ((Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1)) != honey)
            {
                crystalls = Convert.ToUInt64(пополнениемёда.mus1_copy) - Convert.ToUInt64(пополнениемёда.mus1);
            }
            StartCoroutine(web_api_functions_object.request_for_changing_player_resources(player_name: NameInput.Name, honey_amount: honey, crystals_amount: crystalls, callback: (operation_status) =>
                    {
                        if (!operation_status)
                        {
                            Debug.Log("Unexpected error");
                        }
                    }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_changing_shop_resources(player_name: NameInput.Name, shop_name: NameInput.shop_name, honey_amount: 0, crystals_amount: shop_crystalls, callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player bought roze.", player_name: NameInput.Name, honey_amount: "0", crystals_amount: "-3", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            StartCoroutine(web_api_functions_object.request_for_creating_shop_log("Shop selled roze.", player_name: NameInput.Name, shop_name: NameInput.shop_name, honey_amount: "0", crystals_amount: "+3", callback: (operation_status) =>
            {
                if (!operation_status)
                {
                    Debug.Log("Unexpected error");
                }
            }
                )
            );
            HP.text = hp.ToString();
            HP1.text = copy.ToString();
            HP2.text = copy.ToString();
            rose = true;
            gettingRose.SetActive(true);
        }
    }
}