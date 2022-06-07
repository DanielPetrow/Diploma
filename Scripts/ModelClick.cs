using UnityEngine;
using UnityEngine.UI;

public class ModelClick : MonoBehaviour
{
    private const string txtPath = "Canvas/TextLog/Viewport/Content/";

    private Outline outline;

    private GameObject txtContainer, modelToText;

    private void OnMouseEnter()
    {
        outline = gameObject.GetComponent<Outline>();

        if (outline != null)
        {
            outline.enabled = true;
        }
        else
        {  
            gameObject.GetComponentInParent<Outline>().enabled = true;
        }
    }

    private void OnMouseExit()
    {
        outline = gameObject.GetComponent<Outline>();

        if (gameObject.transform.parent != null & gameObject.transform.parent.name != "Assembly")
        {
            txtContainer = GameObject.Find(txtPath + "txt" + gameObject.transform.parent.name);
        }
        else
        {
            txtContainer = GameObject.Find(txtPath + "txt" + gameObject.name);
        }

        if (outline != null & !txtContainer.GetComponent<TextClick>()._isSelected)
        {
            outline.enabled = false;
        }
        else if (outline == null & !txtContainer.GetComponent<TextClick>()._isSelected)
        {
            gameObject.GetComponentInParent<Outline>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.transform.parent != null & gameObject.transform.parent.name != "Assembly")
        {
            modelToText = GameObject.Find(txtPath + "txt" + gameObject.transform.parent.name);
            SetTextComps(modelToText);
        }
        else
        {
            modelToText = GameObject.Find(txtPath + "txt" + gameObject.name);
            SetTextComps(modelToText);
        }
    }

    private void SetTextComps(GameObject model)
    {
        model.GetComponent<Text>().color = Color.yellow;
        model.GetComponent<UnityEngine.UI.Outline>().enabled = true;
        model.GetComponent<TextClick>()._isSelected = true;
    }
}
