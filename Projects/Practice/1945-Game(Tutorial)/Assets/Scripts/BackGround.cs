using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed = 0.01f;
    public Material myMaterial;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        float newoffsetY = myMaterial.mainTextureOffset.y + scrollSpeed * Time.deltaTime;

        Vector2 newoffset = new Vector2(0, newoffsetY);

        myMaterial.mainTextureOffset = newoffset;
    }
}
