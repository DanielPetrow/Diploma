using UnityEngine;

public class ToolTip : MonoBehaviour
{
    public GameObject _toolTip;

    private Transform toolTipPos; 
        
    private Vector3 mousePos;

    private bool IsSelected = false;

    private void Start()
    {
        toolTipPos = _toolTip.GetComponent<Transform>();
        toolTipPos.position = new Vector3(Screen.width / 4.6f, Screen.height / 1.34f, 0);

        _toolTip.SetActive(true);
        _toolTip.SetActive(false);
    }

    private void Update()
    {
        if (!IsSelected)
        {
            mousePos = Input.mousePosition;
            toolTipPos.position = new Vector3(mousePos.x + 330, mousePos.y - 252, 0);
        }
    }

    public void ShowToolTip()
    {
        _toolTip.SetActive(true);
    }

    public void HideToolTip()
    {
        if (!IsSelected)
        {
            _toolTip.SetActive(false);
        }
    }

    public void SetSelected()
    {
        IsSelected = !IsSelected;
    }
}
