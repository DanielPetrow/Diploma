using UnityEngine;
using System.Linq;

public class ModelsMesh : MonoBehaviour
{
    public GameObject[] models;

    private Transform[] allChildren;

    private MeshCollider childMesh;

    private string[] noConvex = {"Hatch", "ReverseAxisBolt", "UnionStopperBolt", "TopLidThFoFork",
        "TopLidLever", "OutputShaftLid", "InputShaftLid", "TopLid", "OutputShaftCoupling"};

    void Start()
    {
        foreach (GameObject model in models)
        {
            if (model.transform.childCount > 0)
            {
                allChildren = model.GetComponentsInChildren<Transform>();

                if (model.GetComponent<MeshRenderer>() != null)
                {
                    model.AddComponent<MeshCollider>();                    
                }

                for (int i = 1; i < allChildren.Length; i++)
                {
                    allChildren[i].gameObject.AddComponent<ModelClick>();
                    childMesh = allChildren[i].gameObject.AddComponent<MeshCollider>();

                    if (allChildren[i].name.Contains("Bolt"))
                    {
                        childMesh.convex = false;
                    }
                    else
                    {
                        childMesh.convex = true;
                    }
                }
            }
            else
            {
                model.AddComponent<MeshCollider>();

                if (noConvex.Contains(model.name))
                {
                    model.GetComponent<MeshCollider>().convex = false;
                }
                else
                {
                    model.GetComponent<MeshCollider>().convex = true;
                }
            }
        }
    }
}
