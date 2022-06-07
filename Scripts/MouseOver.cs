using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour
{
    public Text textContainer;

    public UnityEngine.UI.Outline textOutline;

    public GameObject model;

    public void OnMouseEnter()
    {
        textContainer.color = Color.yellow;
        textOutline.enabled = true;
        model.GetComponent<Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
        if (!gameObject.GetComponent<TextClick>()._isSelected)
        {
            textContainer.color = Color.black;
            textOutline.enabled = false;
            model.GetComponent<Outline>().enabled = false;
        }
    }
}
