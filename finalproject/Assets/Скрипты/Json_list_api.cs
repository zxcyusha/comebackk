/*JSON STRINGS HANDLER*/

using UnityEngine;
using System.Collections.Generic;

public class Json_list_api
{

    static public List<JsonType> creating_list_of_player_objects<JsonType>(string jsons_list_string)
    {
        List<JsonType> list_of_player_objects = new();
        string[] json_strings_list;
        jsons_list_string = jsons_list_string.Trim(new char[] {'[', ']'});
        json_strings_list = jsons_list_string.Split(Other_web_api_strings_container.name_part_of_player_json_in_string);
        foreach (string json_string in json_strings_list)
        {
            if (json_string != "")
            {
                if (json_string[json_string.Length - 1] == ',')
                {
                    list_of_player_objects.Add(JsonUtility.FromJson<JsonType>(Other_web_api_strings_container.name_part_of_player_json_in_string + json_string.Substring(0, json_string.Length - 1)));
                }
                else
                {
                    list_of_player_objects.Add(JsonUtility.FromJson<JsonType>(Other_web_api_strings_container.name_part_of_player_json_in_string + json_string));
                }
            }
        }
        return list_of_player_objects;
    }
}