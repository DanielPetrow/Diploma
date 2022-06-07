using UnityEngine;
using UnityEngine.UI;

public class ShowHideOnKey : MonoBehaviour
{
    public GameObject assembly;

    public Sprite showIcon, hideIcon;

    private GameObject textContainer;

    private Transform parent;

    private const string buPath = "Canvas/TextLog/Viewport/Content/txt";

    private void Start()
    {
        parent = assembly.transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ShowHide();
        }
    }

    private void ShowHide()
    {
        foreach (Transform child in parent)
        {
            if (child.GetComponent<Outline>().enabled == true)
            {
                if (child.transform.childCount > 0 && child.GetComponent<MeshRenderer>() == null)
                {
                    foreach (Transform item in child.transform)
                    {
                        MeshOff(item);
                    }
                }
                else if (child.transform.childCount > 0 && child.GetComponent<MeshRenderer>() != null)
                {
                    foreach (Transform item in child.transform)
                    {
                        MeshOff(item);
                    }
                    MeshOff(child);
                }
                else
                {
                    MeshOff(child);
                }
                
                GameObject.Find(buPath + child.name + "/bu" + child.name + "Visibility").GetComponent<Image>().sprite = hideIcon;
                textContainer = GameObject.Find(buPath + child.name);
                textContainer.GetComponent<UnityEngine.UI.Outline>().enabled = false;
                textContainer.GetComponent<TextClick>()._isSelected = false;
                textContainer.GetComponent<Text>().color = Color.black;

            }
        }
    }

    private void MeshOff(Transform tran)
    {
        tran.gameObject.GetComponent<MeshRenderer>().enabled = false;
        tran.gameObject.GetComponent<MeshCollider>().enabled = false;
    }
}
