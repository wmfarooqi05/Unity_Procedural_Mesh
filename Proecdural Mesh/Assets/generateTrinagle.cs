using UnityEngine;
using System.Collections;
using System;

public class generateTrinagle : MonoBehaviour {

    [SerializeField]
    const int width = 4;
    const int height = 4;

    Mesh mesh;

    // Use this for initialization
    void Start () {

        mesh = new Mesh();

        Vector3[] vertices = new Vector3[(width * height) * 4];

        int vertexIndex1 = 0;
        for (int x=0; x<width; x++)
        {
            for (int y=0; y< height; y++)
            {
                
                vertices[vertexIndex1++] = new Vector3(-1 + x, -1 + y);
                vertices[vertexIndex1++] = new Vector3(1 + x, -1 + y);
                vertices[vertexIndex1++] = new Vector3(1 + x, 1 + y);
                vertices[vertexIndex1++] = new Vector3(-1 + x, 1 + y);
                //vertexIndex1 += 4;
            }
        }
        mesh.vertices = vertices;

        int[] triangles = new int[(width - 1) * (height - 1) * 6]; // 6 for 6 sides of triangle in a cube

        int triangleIndex = 0;

        for (int x = 0; x < width - 1; x++)
        {
            for (int y = 0; y < height - 1; y++)
            {
                int vertexIndex = x * width + y;

                triangles[triangleIndex + 0] = vertexIndex;
                triangles[triangleIndex + 1] = vertexIndex + width;
                triangles[triangleIndex + 2] = vertexIndex + width + 1;
                triangles[triangleIndex + 3] = vertexIndex;
                triangles[triangleIndex + 4] = vertexIndex + width + 1;
                triangles[triangleIndex + 5] = vertexIndex + 1;
            
                triangleIndex += 6;

            }
        }

        
        mesh.triangles = triangles;

        GetComponent<MeshFilter>().mesh = mesh;

	}


    // Update is called once per frame
    void Update () {
	
	}

    void OnDrawGizmos()
    {
        Vector3[] vertices = mesh.vertices;

//        Debug.Log("position in gizmo: " + transform.position);

        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawWireSphere(vertices[i] + transform.position, radius: .1f);
        }
    }

}
