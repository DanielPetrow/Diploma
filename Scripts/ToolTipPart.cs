using UnityEngine;

public class ToolTipPart : MonoBehaviour
{
    public GameObject toolTip;

    private Transform toolTipPos;

    private Vector3 mousePos;

    private bool IsSelected = false;

    private void Start()
    {
        toolTipPos = toolTip.GetComponent<Transform>();
        toolTipPos.position = new Vector3(Screen.width / 4.6f, Screen.height / 1.34f, 0);

        toolTip.SetActive(true);
        toolTip.SetActive(false);
    }

    private void Update()
    {
        if (!IsSelected)
        {
            mousePos = Input.mousePosition;
            toolTipPos.position = new Vector3(mousePos.x + 230, mousePos.y - 252, 0);
        }
    }

    public void ShowToolTip()
    {
        toolTip.SetActive(true);
    }

    public void HideToolTip()
    {
        if (!IsSelected)
        {
            toolTip.SetActive(false);
        }
    }

    public void SetSelected()
    {
        IsSelected = !IsSelected;
    }
}
