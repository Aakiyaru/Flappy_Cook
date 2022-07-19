using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinCanvasmang : MonoBehaviour
{
    public Button SteveVoznyak;
    public Button JohnyIve;
    public Button SteveJobsYoung;
    public Button SteveJobs;

    public GameObject Cook;
    public GameObject Voz;
    public GameObject Ive;
    public GameObject YJobs;
    public GameObject Jobs;

    // Start is called before the first frame update
    void Start()
    {
        int BestScore = PlayerPrefs.GetInt("savescore");

        if (BestScore < 25)
        {
            SteveVoznyak.interactable = false;
        }

        if (BestScore < 50)
        {
            JohnyIve.interactable = false;
        }

        if (BestScore < 100)
        {
            SteveJobsYoung.interactable = false;
        }

        if (BestScore < 200)
        {
            SteveJobs.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int Skin = PlayerPrefs.GetInt("Skin");

        switch (Skin)
        {
            case 0:
                Cook.SetActive(true);
                Voz.SetActive(false);
                Ive.SetActive(false);
                YJobs.SetActive(false);
                Jobs.SetActive(false);
                break;

            case 1:
                Cook.SetActive(false);
                Voz.SetActive(true);
                Ive.SetActive(false);
                YJobs.SetActive(false);
                Jobs.SetActive(false);
                break;

            case 2:
                Cook.SetActive(false);
                Voz.SetActive(false);
                Ive.SetActive(true);
                YJobs.SetActive(false);
                Jobs.SetActive(false);
                break;

            case 3:
                Cook.SetActive(false);
                Voz.SetActive(false);
                Ive.SetActive(false);
                YJobs.SetActive(true);
                Jobs.SetActive(false);
                break;

            case 4:
                Cook.SetActive(false);
                Voz.SetActive(false);
                Ive.SetActive(false);
                YJobs.SetActive(false);
                Jobs.SetActive(true);
                break;
        }
    }
}
