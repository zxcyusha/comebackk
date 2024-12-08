using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class пополнениемёда : MonoBehaviour
{
    static public string mus1_copy = "6390349546303455443";
    static public string mus1 = "6390349546303455443";
    public TMPro.TMP_Text HP;
    public static bool aaa = false;
    public GameObject panel;
    public GameObject ButBack;
    private bool look = false;
    public static int hpp = 0;
    private Web_api_functions web_api_functions_object = new Web_api_functions();


    void Start() {
        ButBack.GetComponent<Button>().onClick.AddListener(delegate { vernuca(); });
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && aaa == true) {
            hpp += Sad.hp;
            Кристаллы.mus2 = Convert.ToString(Convert.ToUInt64(Кристаллы.mus2) - Convert.ToUInt64(Sad.hp));
            ulong honey = Convert.ToUInt64(hpp);
            ulong crystalls = Convert.ToUInt64(Кристаллы.hp);
            if ((Convert.ToUInt64(Кристаллы.mus2_copy) - Convert.ToUInt64(Кристаллы.mus2)) != honey)
            {
                honey = Convert.ToUInt64(Кристаллы.mus2_copy) - Convert.ToUInt64(Кристаллы.mus2);
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
            StartCoroutine(web_api_functions_object.request_for_creating_player_log("Player got honey.", player_name: NameInput.Name, honey_amount: string.Format("+{0}", Sad.hp), crystals_amount: "0", callback: (operation_status) =>
                    {
                    if (!operation_status)
                        {
                            Debug.Log("Unexpected error");
                        }
                    }
                )
            );
            HP.text = hpp.ToString();
            Sad.hp = 0;
        }
    }
    void OnTriggerStay(Collider other) {
        if (Sad.hp != 0 && other.gameObject.tag == "pcheli") {
            aaa = true;
        }
        if (Sad.hp != 0 && other.gameObject.tag == "pcheli" && look == false) {
            panel.SetActive(true);
            look = true;
        }
    }
    void OnTriggerExit(Collider other) {
        aaa = false;
    }
    void vernuca() {
        panel.SetActive(false);
    }
}
