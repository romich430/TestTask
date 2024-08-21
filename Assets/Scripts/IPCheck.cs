using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class IPCheck : MonoBehaviour
{
    [Serializable]
    public class IpApiData
    {
        public string country_name;

        public static IpApiData CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<IpApiData>(jsonString);
        }
    }


    public static IEnumerator GetCountry()
    {
        string ip = new System.Net.WebClient().DownloadString("https://api.ipify.org");
        string uri = $"https://ipapi.co/{ip}/json/";


        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            IpApiData ipApiData = IpApiData.CreateFromJSON(webRequest.downloadHandler.text);

            Debug.Log(ipApiData.country_name);
            if(ipApiData.country_name != "Ukraine")
                Application.OpenURL("https://uk.wikipedia.org/");
        }
    }

    private void Start()
    {
        StartCoroutine(GetCountry());
    }
}
