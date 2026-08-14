using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    private Material _mat;
    [SerializeField] private float _scrollSpeed = 0.5f;

    void Awake()
    {
        _mat = GetComponent<Renderer>().material;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = _mat.mainTextureOffset;

        offset.x += _scrollSpeed * Time.deltaTime;

        _mat.mainTextureOffset = offset;
    }
}
