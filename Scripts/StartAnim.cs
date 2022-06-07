using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class StartAnim : MonoBehaviour
{
    public Dropdown dropdown;

    public GameObject scrollBar, startButtonText;

    public List<GameObject> Assemblys;

    private int SceneId;

    private GameObject textContainer;

    private Animation currentCameraAnim, currentModelAnim, currentTextAnim, currentGasketAnim;

    private string animName, modelPath;
    private const string animCamera = "animCamera", animModel = "animModel", animText = "animText", gasket = "Gasket";
    private const string textPath = "AnimInfoCanvas/ScrollView/Viewport/Content/animText";

    private void Start()
    {

        dropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(dropdown); });

        animName = "OutputShaftCoupling";

        modelPath = "Assembly/";

        textContainer = GameObject.Find(textPath + animName);

        currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
        currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
        currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

        currentGasketAnim = null;
    }

    private void DropdownValueChanged(Dropdown change)
    {
        SceneId = change.value;

        switch (SceneId)
        {
            case 0: // OutputShaftCoupling + Gasket

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop(animModel + animName + gasket);
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(0);

                animName = "OutputShaftCoupling";

                modelPath = "Assembly/";

                currentGasketAnim = null;

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);

                break;

            case 1: // Hatch + Gasket

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(0);

                animName = "Hatch";

                modelPath = "Assembly/";

                currentGasketAnim = GameObject.Find(modelPath + animName + gasket).GetComponent<Animation>();

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);
                PrepareAnim(currentGasketAnim, animModel + animName + gasket);

                break;

            case 2: // InputShaftLid + Gasket

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(0);

                animName = "InputShaftLid";                

                modelPath = "Assembly/";

                currentGasketAnim = GameObject.Find(modelPath + animName + gasket).GetComponent<Animation>();

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);
                PrepareAnim(currentGasketAnim, animModel + animName + gasket);

                break;

            case 3: // CounterShaftLid + Gasket

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(0);

                animName = "CounterShaftLid";

                modelPath = "Assembly/";

                currentGasketAnim = GameObject.Find(modelPath + animName + gasket).GetComponent<Animation>();

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);
                PrepareAnim(currentGasketAnim, animModel + animName + gasket);

                break;

            case 4: // TopLidLever

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(0);

                animName = "TopLidLever";

                modelPath = "Assembly/";

                currentGasketAnim = null;

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);

                break;

            case 5: // OutputShaftLid + Gasket

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(1);

                animName = "OutputShaftLid";

                modelPath = "Assembly1/";

                currentGasketAnim = GameObject.Find(modelPath + animName + gasket).GetComponent<Animation>();

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);
                PrepareAnim(currentGasketAnim, animModel + animName + gasket);

                break;

            case 6: // TopLid + Gasket

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(1);

                animName = "TopLid";

                modelPath = "Assembly1/";

                currentGasketAnim = GameObject.Find(modelPath + animName + gasket).GetComponent<Animation>();

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);
                PrepareAnim(currentGasketAnim, animModel + animName + gasket);

                break;

            case 7: // FirstGear

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(2);

                animName = "FirstGear";

                modelPath = "Assembly2/";

                currentGasketAnim = null;

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);

                break;

            case 8: // SecondGear

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(3);

                animName = "SecondGear";

                modelPath = "Assembly3/";

                currentGasketAnim = null;

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);

                break;

            case 9: // ThirdFourthGear

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(4);

                animName = "ThirdFourthGear";

                modelPath = "Assembly4/";

                currentGasketAnim = null;

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);

                break;

            case 10: // ReverseGear

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(5);

                animName = "ReverseGear";

                modelPath = "Assembly5/";

                currentGasketAnim = null;

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);

                break;

            case 11: // PlungerFinger

                startButtonText.GetComponent<Text>().text = "Запуск анимации";

                StopPreviousAnim(currentCameraAnim, animCamera + animName);
                StopPreviousAnim(currentModelAnim, animModel + animName);
                StopPreviousAnim(currentTextAnim, animText + animName);

                if (currentGasketAnim != null)
                {
                    currentGasketAnim.Stop();
                    currentGasketAnim.Play(animModel + animName + gasket);
                    currentGasketAnim[animModel + animName + gasket].speed = 0f;
                    currentGasketAnim[animModel + animName + gasket].time = 0f;
                }

                ShowHideAssembly(6);

                animName = "PlungerFinger";

                modelPath = "Assembly6/";

                currentGasketAnim = null;

                textContainer.SetActive(false);
                textContainer = GameObject.Find(textPath + animName);
                textContainer.SetActive(true);

                currentCameraAnim = GameObject.Find("Main Camera").GetComponent<Animation>();
                currentModelAnim = GameObject.Find(modelPath + animName).GetComponent<Animation>();
                currentTextAnim = GameObject.Find(textPath + animName).GetComponent<Animation>();

                PrepareAnim(currentCameraAnim, animCamera + animName);
                PrepareAnim(currentModelAnim, animModel + animName);
                PrepareAnim(currentTextAnim, animText + animName);

                break;

            default:
                Debug.Log("Ошибка номера анимации");
                break;
        }
    }

    public void StartAnimation()
    {
        if (startButtonText.GetComponent<Text>().text == "Запуск анимации") {

            scrollBar.GetComponent<Scrollbar>().value = 1;

            currentCameraAnim.Play(animCamera + animName);
            currentModelAnim.Play(animModel + animName);
            currentTextAnim.Play(animText + animName);

            if (currentGasketAnim != null)
            {
                currentGasketAnim.Play(animModel + animName + gasket);
            }

            currentCameraAnim[animCamera + animName].speed = 1f;
            currentModelAnim[animModel + animName].speed = 1f;
            currentTextAnim[animText + animName].speed = 1f;

            if (currentGasketAnim != null)
            {
                currentGasketAnim[animModel + animName + gasket].speed = 1f;
            }

            startButtonText.GetComponent<Text>().text = "Перезапуск анимации";
        }

        else if (startButtonText.GetComponent<Text>().text == "Перезапуск анимации")
        {
            currentCameraAnim.Stop();
            currentModelAnim.Stop();
            currentTextAnim.Stop();

            currentCameraAnim.Play(animCamera + animName);
            currentModelAnim.Play(animModel + animName);
            currentTextAnim.Play(animText + animName);

            currentCameraAnim[animCamera + animName].speed = 1f;
            currentModelAnim[animModel + animName].speed = 1f;
            currentTextAnim[animText + animName].speed = 1f;

            if (currentGasketAnim != null)
            {
                currentGasketAnim.Stop();
                currentGasketAnim.Play(animModel + animName + gasket);
                currentGasketAnim[animModel + animName + gasket].speed = 1f;
            }
        }
    }

    public void ResumeAnim()
    {
        currentCameraAnim[animCamera + animName].speed = 1f;
        currentModelAnim[animModel + animName].speed = 1f;
        currentTextAnim[animText + animName].speed = 1f;

        if (currentGasketAnim != null)
        {
            currentGasketAnim[animModel + animName + gasket].speed = 1f;
        }
    }

    public void PauseAnim()
    {
        currentCameraAnim[animCamera + animName].speed = 0f;
        currentModelAnim[animModel + animName].speed = 0f;
        currentTextAnim[animText + animName].speed = 0f;

        if (currentGasketAnim != null)
        {
            currentGasketAnim[animModel + animName + gasket].speed = 0f;
        }
    }

    public void ForwardAnim()
    {
        currentCameraAnim[animCamera + animName].speed += 0.5f;
        currentModelAnim[animModel + animName].speed += 0.5f;
        currentTextAnim[animText + animName].speed += 0.5f;

        if (currentGasketAnim != null)
        {
            currentGasketAnim[animModel + animName + gasket].speed += 0.5f;
        }
    }

    private void StopPreviousAnim(Animation anim, string animName)
    {
        anim.Stop();
        anim.Play(animName);
        anim[animName].speed = 0f;
        anim[animName].time = 0f;
    }

    private void PrepareAnim(Animation anim, string animName)
    {
        anim.Play(animName);
        anim[animName].speed = 0f;
    }

    private void ShowHideAssembly(int assemblyNumber)
    {
        for (int i = 0; i < Assemblys.Count; i++)
        {
            if (assemblyNumber == i)
            {
                Assemblys[i].transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            }
            else
            {
                Assemblys[i].transform.localScale = Vector3.zero;
            }
        }
    }
}
