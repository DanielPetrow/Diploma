using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour
{
    public Sprite _visibleIcon, _hideIcon, _icon;

    private GameObject buttonClicked, model;

    private string parentName;

    private const string buPath = "Canvas/TextLog/Viewport/Content/";
    private const string modelPath = "Assembly/";

    public void ShowHideModel()
    {
        parentName = ("txt" + (EventSystem.current.currentSelectedGameObject.name).Substring(2)).Replace("Visibility", "");
        buttonClicked = GameObject.Find(buPath + parentName + "/" + EventSystem.current.currentSelectedGameObject.name);
        _icon = buttonClicked.GetComponent<Image>().sprite;
        model = GameObject.Find(modelPath + ((EventSystem.current.currentSelectedGameObject.name).Substring(2)).Replace("Visibility", ""));

        if (_icon.name == "visibleIcon")
        {
            if (model.transform.childCount > 0)
            {
                if (model.GetComponent<MeshRenderer>() != null)
                {
                    MeshOff(model);
                }

                foreach (Transform child in model.transform)
                {
                    MeshOff(child);
                }
            }
            else
            {
                MeshOff(model);
            }

            buttonClicked.GetComponent<Image>().sprite = _hideIcon;
        }
        else
        {
            if (model.transform.childCount > 0)
            {
                if (model.GetComponent<MeshRenderer>() != null)
                {
                    MeshOn(model);
                }

                foreach (Transform child in model.transform)
                {
                    MeshOn(child);
                }
            }
            else
            {
                MeshOn(model);
            }

            buttonClicked.GetComponent<Image>().sprite = _visibleIcon;
        }
    }

    private void MeshOn(GameObject model)
    {
        model.GetComponent<MeshRenderer>().enabled = true;
        model.GetComponent<MeshCollider>().enabled = true;
    }

    private void MeshOn(Transform child)
    {
        child.GetComponent<MeshRenderer>().enabled = true;
        child.GetComponent<MeshCollider>().enabled = true;
    }

    private void MeshOff(GameObject model)
    {
        model.GetComponent<MeshRenderer>().enabled = false;
        model.GetComponent<MeshCollider>().enabled = false;
    }

    private void MeshOff(Transform child)
    {
        child.GetComponent<MeshRenderer>().enabled = false;
        child.GetComponent<MeshCollider>().enabled = false;
    }
}
