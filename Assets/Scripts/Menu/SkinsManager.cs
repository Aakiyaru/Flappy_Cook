using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsManager : MonoBehaviour
{

    public GameObject TimCook;
    public GameObject SteveVoz;
    public GameObject JohnyI;
    public GameObject YJobs;
    public GameObject Jobs;

    // Start is called before the first frame update
    void Start()
    {
        int index = PlayerPrefs.GetInt("Skin");
        Debug.Log($"Skin changed [{index}]");
        switch (index)
        {
            case 0:
                TimCook.SetActive(true);
                SteveVoz.SetActive(false);
                JohnyI.SetActive(false);
                YJobs.SetActive(false);
                Jobs.SetActive(false);
                break;

            case 1:
                TimCook.SetActive(false);
                SteveVoz.SetActive(true);
                JohnyI.SetActive(false);
                YJobs.SetActive(false);
                Jobs.SetActive(false);
                break;

            case 2:
                TimCook.SetActive(false);
                SteveVoz.SetActive(false);
                JohnyI.SetActive(true);
                YJobs.SetActive(false);
                Jobs.SetActive(false);
                break;

            case 3:
                TimCook.SetActive(false);
                SteveVoz.SetActive(false);
                JohnyI.SetActive(false);
                YJobs.SetActive(true);
                Jobs.SetActive(false);
                break;

            case 4:
                TimCook.SetActive(false);
                SteveVoz.SetActive(false);
                JohnyI.SetActive(false);
                YJobs.SetActive(false);
                Jobs.SetActive(true);
                break;
        }
    }

    public void SetPlayer(int index)
    {
        PlayerPrefs.SetInt("Skin", index);
        Debug.Log($"Skin changed [{index}]");
    }
}
