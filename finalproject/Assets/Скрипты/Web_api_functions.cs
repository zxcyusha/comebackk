/*THATS WRAPPER FOR NTO API*/

using UnityEngine;
using System.Collections;

using UnityEngine.Networking;
using System.Collections.Generic;

public class Web_api_functions : Basic_web_api_functions
{
    private string url_for_creating_player_api = string.Format("{0}{1}{2}", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part);
    private string url_for_creating_logs_api = string.Format("{0}{1}{2}", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_logs_create_url_part);

    public IEnumerator request_for_creating_player(string player_name, ulong honey_amount = 0, ulong crystals_amount = 0, System.Action<bool> callback = null)
    {
        UnityWebRequest ready_request_api_object = null;
        json_serializables_classes.Player player_object = new json_serializables_classes.Player();
        player_object.name = player_name;
        json_serializables_classes.Resources resources_object = new json_serializables_classes.Resources();
        resources_object.honey = honey_amount;
        resources_object.crystals = crystals_amount;
        player_object.resources = resources_object;
        string json_body = JsonUtility.ToJson(player_object);
        yield return post(website_url: url_for_creating_player_api, json_body: json_body, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300)) 
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }

    public IEnumerator request_for_getting_players_list(System.Action<bool, List<json_serializables_classes.Player>> callback = null)
    {
        UnityWebRequest ready_request_api_object = null;
        yield return get(website_url: url_for_creating_player_api, callback: (request_api_object) =>
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        List<json_serializables_classes.Player> list_of_player_objects = Json_list_api.creating_list_of_player_objects<json_serializables_classes.Player>(ready_request_api_object.downloadHandler.text);
        callback?.Invoke(operation_status, list_of_player_objects);
    }

    public IEnumerator request_for_getting_player_resources(string player_name, System.Action<bool, json_serializables_classes.Player> callback = null)
    {
        string url_for_getting_player_resources_api = string.Format("{0}{1}{2}{3}/", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name);
        UnityWebRequest ready_request_api_object = null;
        yield return get(website_url: url_for_getting_player_resources_api, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        json_serializables_classes.Player player_object = JsonUtility.FromJson<json_serializables_classes.Player>(ready_request_api_object.downloadHandler.text);
        callback?.Invoke(operation_status, player_object);

    }

    public IEnumerator request_for_changing_player_resources(string player_name, ulong honey_amount, ulong crystals_amount, System.Action<bool> callback = null)
    {
        string url_for_changing_player_resources_api = string.Format("{0}{1}{2}{3}/", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name);
        UnityWebRequest ready_request_api_object = null;
        json_serializables_classes.Resources resources_object = new json_serializables_classes.Resources();
        resources_object.honey = honey_amount;
        resources_object.crystals = crystals_amount;
        json_serializables_classes.Update_resources update_resources_object = new json_serializables_classes.Update_resources();
        update_resources_object.resources = resources_object;
        string json_body = JsonUtility.ToJson(update_resources_object);
        yield return put(website_url: url_for_changing_player_resources_api, json_body: json_body, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }

    public IEnumerator request_for_deleting_player(string player_name, System.Action<bool> callback = null)
    {
        string url_for_deleting_player_api = string.Format("{0}{1}{2}{3}/", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name);
        UnityWebRequest ready_request_api_object = null;
        yield return delete(website_url: url_for_deleting_player_api, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }

    public IEnumerator request_for_creating_player_log(string comment_for_log, string player_name, string honey_amount = "0", string crystals_amount = "0", System.Action<bool> callback = null)
    {
        UnityWebRequest ready_request_api_object = null;
        json_serializables_classes.Player_log player_log_object = new json_serializables_classes.Player_log();
        player_log_object.comment = comment_for_log;
        player_log_object.player_name = player_name;
        json_serializables_classes.Resources_changed resources_changed_object = new json_serializables_classes.Resources_changed();
        resources_changed_object.honey_changed = honey_amount;
        resources_changed_object.crystals_changed = crystals_amount;
        player_log_object.resources_changed = resources_changed_object;
        string json_body = JsonUtility.ToJson(player_log_object);
        yield return post(website_url: url_for_creating_logs_api, json_body: json_body, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }

    public IEnumerator request_for_creating_shop(string player_name, string shop_name, ulong honey_amount = 0, ulong crystals_amount = 0, System.Action<bool> callback = null)
    {
        string url_for_creating_shop = string.Format("{0}{1}{2}{3}{4}", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name, Web_api_strings_container.nto_shops_create_url_part);
        UnityWebRequest ready_request_api_object = null;
        json_serializables_classes.Shop shop_object = new json_serializables_classes.Shop();
        shop_object.name = shop_name;
        json_serializables_classes.Resources resources_object = new json_serializables_classes.Resources();
        resources_object.honey = honey_amount;
        resources_object.crystals = crystals_amount;
        shop_object.resources = resources_object;
        string json_body = JsonUtility.ToJson(shop_object);
        yield return post(website_url: url_for_creating_shop, json_body: json_body, callback: (request_api_object) => 
            {
            ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }

    public IEnumerator request_for_getting_shops_list(string player_name, System.Action<bool, List<json_serializables_classes.Shop>> callback = null)
    {
        string url_for_getting_shops_list = string.Format("{0}{1}{2}{3}{4}", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name, Web_api_strings_container.nto_shops_create_url_part);
        UnityWebRequest ready_request_api_object = null;
        yield return get(website_url: url_for_getting_shops_list, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        List<json_serializables_classes.Shop> list_of_shops_objects = Json_list_api.creating_list_of_player_objects<json_serializables_classes.Shop>(ready_request_api_object.downloadHandler.text);
        callback?.Invoke(operation_status, list_of_shops_objects);
    }

    public IEnumerator request_for_getting_shop_resources(string player_name, string shop_name, System.Action<bool, json_serializables_classes.Shop> callback = null)
    {
        string url_for_getting_shop_resources = string.Format("{0}{1}{2}{3}{4}{5}/", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name, Web_api_strings_container.nto_shops_create_url_part, shop_name);
        UnityWebRequest ready_request_api_object = null;
        yield return get(website_url: url_for_getting_shop_resources, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        json_serializables_classes.Shop player_object = JsonUtility.FromJson<json_serializables_classes.Shop>(ready_request_api_object.downloadHandler.text);
        callback?.Invoke(operation_status, player_object);
    }

    public IEnumerator request_for_changing_shop_resources(string player_name, string shop_name, ulong honey_amount, ulong crystals_amount, System.Action<bool> callback = null)
    {
        string url_for_changing_shop_resources = string.Format("{0}{1}{2}{3}{4}{5}/", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name, Web_api_strings_container.nto_shops_create_url_part, shop_name);
        UnityWebRequest ready_request_api_object = null;
        json_serializables_classes.Resources resources_object = new json_serializables_classes.Resources();
        resources_object.honey = honey_amount;
        resources_object.crystals = crystals_amount;
        json_serializables_classes.Update_resources update_resources_object = new json_serializables_classes.Update_resources();
        update_resources_object.resources = resources_object;
        string json_body = JsonUtility.ToJson(update_resources_object);
        yield return put(website_url: url_for_changing_shop_resources, json_body: json_body, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }

    public IEnumerator request_for_deleting_shop(string player_name, string shop_name, System.Action<bool> callback = null)
    {
        string url_for_deleting_shop_api = string.Format("{0}{1}{2}{3}{4}{5}/", Web_api_strings_container.nto_basic_api_url, Web_api_strings_container.nto_api_uuid, Web_api_strings_container.nto_players_create_url_part, player_name, Web_api_strings_container.nto_shops_create_url_part, shop_name);
        UnityWebRequest ready_request_api_object = null;
        yield return delete(website_url: url_for_deleting_shop_api, callback: (request_api_object) => 
            {
                ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }

    public IEnumerator request_for_creating_shop_log(string comment_for_log, string player_name, string shop_name, string honey_amount = "0", string crystals_amount = "0", System.Action<bool> callback = null)
    {
        UnityWebRequest ready_request_api_object = null;
        json_serializables_classes.Shop_log player_log_object = new json_serializables_classes.Shop_log();
        player_log_object.comment = comment_for_log;
        player_log_object.player_name = player_name;
        player_log_object.shop_name = shop_name;
        json_serializables_classes.Resources_changed resources_changed_object = new json_serializables_classes.Resources_changed();
        resources_changed_object.honey_changed = honey_amount;
        resources_changed_object.crystals_changed = crystals_amount;
        player_log_object.resources_changed = resources_changed_object;
        string json_body = JsonUtility.ToJson(player_log_object);
        yield return post(website_url: url_for_creating_logs_api, json_body: json_body, callback: (request_api_object) => 
            {
            ready_request_api_object = request_api_object;
            }
        );
        bool operation_status = false;
        if ((ready_request_api_object.responseCode >= 200) & (ready_request_api_object.responseCode < 300))
        {
            operation_status = true;
        }
        callback?.Invoke(operation_status);
    }
}