using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Renderer : MonoBehaviour {
    [SerializeField] private int width = 10;
    [SerializeField] private int height = 10;
    private float vertical;
    [SerializeField] private Transform wall;
    [SerializeField] private float length;


    public Vector3 GetNodeCenter(int i, int j) {
        if (i >= width || j >= height || i < 0 || j < 0) return Vector3.zero;
        
        // length = length * Mathf.Cos(30 * Mathf.Deg2Rad);
        // vertical = length + (length * Mathf.Sin(30 * Mathf.Deg2Rad));
                
        Vector3 pos = new Vector3((i - width / 2) * length, transform.position.y, (j - height / 2) * length); // center of node
                
        // if (j % 2 == 0) {
        //     pos -= new Vector3(length, 0, 0);
        // }

        return pos;
    }
    
    void Render(Generator.NodeState[,] maze) {
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                Generator.NodeState node = maze[i, j];

                string name = i.ToString() + j.ToString();
                Vector3 pos = GetNodeCenter(i, j);                

                if (node.HasFlag(Generator.NodeState.Up)) {
                    Transform up = Instantiate(wall, transform);
                    
                    // up.eulerAngles = new Vector3(0, -30, 0);
                    up.position = pos + new Vector3(0, 0, length / 2);
                    up.name = "upLeft" + name;
                    
                }
                // //
                if (node.HasFlag(Generator.NodeState.Left)) {
                    Transform left = Instantiate(wall, transform);
                    
                    // left.eulerAngles = new Vector3(0, 90, 0);
                    left.position = pos + new Vector3(-length / 2, 0, 0);
                    left.name = "left" + name;
                }


                if (j == 0) {
                    if (node.HasFlag(Generator.NodeState.Down)) {
                        Transform downRight = Instantiate(wall, transform);
                        
                        // downRight.eulerAngles = new Vector3(0, -30, 0);
                        downRight.position = pos + new Vector3(0, 0, -length / 2);
                        downRight.name = "downRight" + name;
                    }
                }

                if (i == width - 1) {
                    if (node.HasFlag(Generator.NodeState.Right)) {
                        Transform left = Instantiate(wall, transform);
                        

                        // left.eulerAngles = new Vector3(0, 90, 0);
                        left.position = pos + new Vector3(length / 2, 0, 0);
                        left.name = "right" + name;
                    }
                }

            }
        }    
    }
    

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            
            foreach (Transform t in transform) {
                if (t.name != "Ground") {
                    
                    Destroy(t.gameObject);
                }
            }

            Render(Generator.Generate(width, height));

        }
    }
}
