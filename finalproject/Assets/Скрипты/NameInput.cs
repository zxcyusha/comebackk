using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Xml.Linq;

public class NameInput : MonoBehaviour
{
    public TMP_InputField textt;
    public static string Name;
    public static string shop_name = "";
    public GameObject pole;
    public GameObject predup;
    public void InputNamePlayer() 
    {
        if (textt.text == "") 
        {
            predup.SetActive(true);
        }
        else 
        {
            Web_api_functions web_api_functions_object = new Web_api_functions();
            Name = textt.text;
            StartCoroutine(web_api_functions_object.request_for_creating_player(player_name: Name, callback: (operation_status) =>
                    {
                        if (operation_status) 
                        {
                            shop_name = string.Format("shop_for_{0}", Name);
                            StartCoroutine(web_api_functions_object.request_for_creating_shop(player_name: Name, shop_name: shop_name, callback: (operation_status) =>
                                {
                                    Debug.Log(Name);
                                    pole.SetActive(false);
                                }
                                )
                            );
                        }
                        else
                        {
                            predup.SetActive(true);
                        }
                    }
                )
            );
        }
    }
}