using UnityEngine;
using System.Collections;

public class generateMesh : MonoBehaviour {
    private float speed;
    Mesh mesh;


    // Use this for initialization
    void Start () {

        // assign points
        mesh = new Mesh();
        
        Vector3[] vertices = new Vector3[3];
        
        vertices[0] = new Vector3(0, 1, 0);
        vertices[1] = new Vector3(1,0, 0);
        vertices[2] = new Vector3(0, 0, 0);

        /*
        vertices[0] = new Vector3(-1, -1, 0);
        vertices[1] = new Vector3(0, .8f, 0);
        vertices[2] = new Vector3(1, -1, 0);
        */
        mesh.vertices = vertices;
        
        // assign triangles
        int[] triangles =  new int[3] { 0, 1, 2 };
        mesh.triangles = triangles;

        GetComponent<MeshFilter>().mesh = mesh;
        
        // Initializing Normals
        Vector3[] normals = new Vector3[3];
        normals[0] = Vector3.forward;
        normals[1] = Vector3.forward;
        normals[2] = Vector3.forward;

        // Assign Normals
        mesh.normals = normals;

        /*
        Vector2[] uvs = new Vector2[3];
        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(0, 1);
        uvs[2] = new Vector2(1, 0);
        */
//        uvs[3] = new Vector2(1, 1);
        //mesh.uv = uvs;





    }
	
	// Update is called once per frame
	void Update () {
        // Creating Colors
        /*
        Color32[] colors = new Color32[3];

        float offset = Time.time * speed;

        float color = Color.white.GetHashCode() + offset;
        Material mat = GetComponent<Material>();

        Search for this
        ColorFromHue()

        
        colors[0] = Color.Lerp(Color.white,Color.red, offset);
        colors[1] = Color.Lerp(Color.white, Color.blue, offset);
        colors[2] = Color.Lerp(Color.white, Color.green, offset);
        */
        //mesh.colors32 = colors;
        // = colors;
    }

    void OnDrawGizmos()
    {
        Vector3[] vertices = mesh.vertices;

        for(int i=0; i<vertices.Length; i++)
        {
            Gizmos.DrawWireSphere(center: vertices[i] + transform.position, radius: .1f);
        }
    }

}
