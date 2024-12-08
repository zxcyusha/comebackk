using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class забор : MonoBehaviour
{
    public Animator Anim;
    public TMPro.TMP_Text HP;
    public GameObject zabor;
    public GameObject panel;
    public GameObject textt;
    private bool pon = false;
    string hp = "Мёд является топливом и поможет улететь тебе обратно на твою планету. Пчёлам нужна пыльца, соответственно, твоя задача - ухаживать за садом. Однако не затягивай с этим, ведь пчёлы могут умереть, а ты так и останешься на этой планете!";
    private bool net = false;
    void Start()
    {
        Anim = zabor.GetComponent<Animator>();
        HP.text = hp.ToString();
    }
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "zabor") {
            if (pon == false) {
                textt.SetActive(true);
            }
             if (net == false) {
            panel.SetActive(true);
            hp = "Найди на карте грабли, лейку и семена. Регулярно пропалывай, поливай почву и сей семена (выполнять нужно именно в таком порядке). Нажимай на C, чтобы выполнять действия на огороде.";
            HP.text = hp.ToString();
            net = true;
             }
            if (Input.GetKeyDown(KeyCode.O)) {
                Anim.SetBool("pule", true);
                pon = true;
            }
        }
    }
    void OnTriggerExit(Collider other) {
        textt.SetActive(false);
    }
}
