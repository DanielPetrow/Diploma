using UnityEngine;
using UnityEngine.EventSystems;

public class TextClick : MonoBehaviour, IPointerClickHandler
{
    public bool _isSelected = false;

    private SceneControl _script;

    private string scenePartName;

    private void Start()
    {
        _script = GameObject.Find("SceneControl").GetComponent<SceneControl>();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.clickCount == 2)
        {
            scenePartName = gameObject.name.Substring(3);
            _script.OpenPartScene(scenePartName);
        }
        else 
        {
            gameObject.GetComponent<TextClick>()._isSelected = !gameObject.GetComponent<TextClick>()._isSelected;
        }
    }
}
