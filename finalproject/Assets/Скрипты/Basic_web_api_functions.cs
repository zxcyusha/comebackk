/*THATS WRAPPER FOR UNITY WEB REQUESTS*/

using System.Text;
using System.Collections;

using UnityEngine.Networking;

public class Basic_web_api_functions
{
    public IEnumerator get(string website_url, int redirect_limit = 10, int timeout_limit = 10, System.Action<UnityWebRequest> callback = null)
    {
        UnityWebRequest request_api_object = UnityWebRequest.Get(website_url);
        request_api_object.method = UnityWebRequest.kHttpVerbGET;
        request_api_object.downloadHandler = new DownloadHandlerBuffer();
        request_api_object.SetRequestHeader(Headers_strings_container.content_type_header, Headers_strings_container.headers_value);
        request_api_object.SetRequestHeader(Headers_strings_container.accept_header, Headers_strings_container.headers_value);
        request_api_object.redirectLimit = 10;
        request_api_object.timeout = 10;
        yield return request_api_object.SendWebRequest();
        callback?.Invoke(request_api_object);
    }

    public IEnumerator put(string website_url, string json_body = null, int redirect_limit = 10, int timeout_limit = 10, System.Action<UnityWebRequest> callback = null)
    {
        UnityWebRequest request_api_object = UnityWebRequest.Put(website_url, json_body);
        request_api_object.method = UnityWebRequest.kHttpVerbPUT;
        request_api_object.downloadHandler = new DownloadHandlerBuffer();
        request_api_object.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json_body));
        request_api_object.SetRequestHeader(Headers_strings_container.content_type_header, Headers_strings_container.headers_value);
        request_api_object.SetRequestHeader(Headers_strings_container.accept_header, Headers_strings_container.headers_value);
        request_api_object.redirectLimit = redirect_limit;
        request_api_object.timeout = timeout_limit;
        yield return request_api_object.SendWebRequest();
        callback?.Invoke(request_api_object);
    }

    public IEnumerator post(string website_url, string json_body = null, int redirect_limit = 10, int timeout_limit = 10, System.Action<UnityWebRequest> callback = null)
    {
        UnityWebRequest request_api_object = UnityWebRequest.PostWwwForm(website_url, json_body);
        request_api_object.method = UnityWebRequest.kHttpVerbPOST;
        request_api_object.downloadHandler = new DownloadHandlerBuffer();
        request_api_object.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json_body));
        request_api_object.SetRequestHeader(Headers_strings_container.content_type_header, Headers_strings_container.headers_value);
        request_api_object.SetRequestHeader(Headers_strings_container.accept_header, Headers_strings_container.headers_value);
        request_api_object.redirectLimit = 10;
        request_api_object.timeout = 10;
        yield return request_api_object.SendWebRequest();
        callback?.Invoke(request_api_object);
    }

    public IEnumerator delete(string website_url, int redirect_limit = 10, int timeout_limit = 10, System.Action<UnityWebRequest> callback = null)
    {
        UnityWebRequest request_api_object = UnityWebRequest.Delete(website_url);
        request_api_object.method = UnityWebRequest.kHttpVerbDELETE;
        request_api_object.SetRequestHeader(Headers_strings_container.content_type_header, Headers_strings_container.headers_value);
        request_api_object.SetRequestHeader(Headers_strings_container.accept_header, Headers_strings_container.headers_value);
        request_api_object.redirectLimit = 10;
        request_api_object.timeout = 10;
        yield return request_api_object.SendWebRequest();
        callback?.Invoke(request_api_object);
    }
}