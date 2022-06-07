using UnityEngine;
using UnityEngine.UI;

public class txtOptions : MonoBehaviour
{
    public Text[] textContainers;

    private MouseOver mouseOver;

    private new BoxCollider2D collider;

    private string modelName;

    private float width, height;

    private void Start()
    {
        foreach(Text item in textContainers)
        {
            mouseOver = item.GetComponent<MouseOver>();
            collider = item.gameObject.AddComponent<BoxCollider2D>();

            mouseOver.textContainer = item;
            mouseOver.textOutline = item.GetComponent<UnityEngine.UI.Outline>();

            modelName = item.name.Substring(3);
            mouseOver.model = GameObject.Find("Assembly/" + modelName);

            height = item.rectTransform.rect.height;
            width = item.rectTransform.rect.width;
            collider.size = new Vector2(width, height - 5);
            collider.offset = new Vector2(-0.7f, 0.5f);
        }
    }
}
