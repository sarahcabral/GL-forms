using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade1 : MonoBehaviour
{
    public Material mat;
    public int op;

    private void OnPostRender()
    {
        GL.PushMatrix();
        mat.SetPass(0);
        GL.Begin(GL.LINES);


        switch (op)
        {
            case 1: //Forma 1-------------

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(5, 0, 0);

                GL.Vertex3(5, 0, 0);
                GL.Vertex3(5, 5, 0);

                GL.Vertex3(5, 5, 0);
                GL.Vertex3(0, 5, 0);

                GL.Vertex3(0, 5, 0);
                GL.Vertex3(0, 0, 0);
                break;
            case 2: // Forma 2------------ 

                GL.Vertex3(-3, 0, 0);
                GL.Vertex3(3, 0, 0);

                GL.Vertex3(3, 0, 0);
                GL.Vertex3(0, 5.5f, 0);

                GL.Vertex3(0, 5.5f, 0);
                GL.Vertex3(-3, 0, 0);
                break;
            case 3: //Forma 3-------------

                GL.Vertex3(0, 2, 0);
                GL.Vertex3(1.2f, 2, 0);

                GL.Vertex3(1.2f, 2, 0);
                GL.Vertex3(2.2f, 1, 0);

                GL.Vertex3(2.2f, 1, 0);
                GL.Vertex3(2.2f, 0, 0);

                GL.Vertex3(2.2f, 0, 0);
                GL.Vertex3(1.2f, -1, 0);

                GL.Vertex3(1.2f, -1, 0);
                GL.Vertex3(0, -1, 0);

                GL.Vertex3(0, -1, 0);
                GL.Vertex3(-1, 0, 0);

                GL.Vertex3(-1, 0, 0);
                GL.Vertex3(-1, 1, 0);

                GL.Vertex3(-1, 1, 0);
                GL.Vertex3(0, 2, 0);
                break;
            case 4: //Forma 4 -------------

                GL.Vertex3(-2, 2, 0);
                GL.Vertex3(-2, -2, 0);

                GL.Vertex3(-2, -2, 0);
                GL.Vertex3(2, -2, 0);

                GL.Vertex3(2, -2, 0);
                GL.Vertex3(2, 2, 0);

                GL.Vertex3(2, 2, 0);
                GL.Vertex3(-2, 2, 0);

                GL.Vertex3(-2, 2, 0);
                GL.Vertex3(-2, 2, 0);

                GL.Vertex3(-1.5f, 2, 0);
                GL.Vertex3(-1.5f, -2, 0);

                GL.Vertex3(-2, 1.5f, 0);
                GL.Vertex3(2, 1.5f, 0);
                break;
            case 5: //Forma 5 -------------

                GL.Vertex3(0, -0.6f, 0);
                GL.Vertex3(0.7f, -1.3f, 0);

                GL.Vertex3(0.7f, -1.3f, 0);
                GL.Vertex3(1.3f, -0.7f, 0);

                GL.Vertex3(1.3f, -0.7f, 0);
                GL.Vertex3(0.6f, 0, 0);

                GL.Vertex3(0.6f, 0, 0);
                GL.Vertex3(1.3f, 0.7f, 0);

                GL.Vertex3(1.3f, 0.7f, 0);
                GL.Vertex3(0.7f, 1.3f, 0);

                GL.Vertex3(0.7f, 1.3f, 0);
                GL.Vertex3(0, 0.6f, 0);

                GL.Vertex3(0, 0.6f, 0);
                GL.Vertex3(-0.7f, 1.3f, 0);

                GL.Vertex3(-0.7f, 1.3f, 0);
                GL.Vertex3(-1.3f, 0.7f, 0);

                GL.Vertex3(-1.3f, 0.7f, 0);
                GL.Vertex3(-0.6f, 0, 0);

                GL.Vertex3(-0.6f, 0, 0);
                GL.Vertex3(-1.3f, -0.7f, 0);

                GL.Vertex3(-1.3f, -0.7f, 0);
                GL.Vertex3(-0.7f, -1.3f, 0);

                GL.Vertex3(-0.7f, -1.3f, 0);
                GL.Vertex3(0, -0.6f, 0);
                break;
            case 6: //Forma 6

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(2.5f, 0, 0);

                GL.Vertex3(2.5f, 0, 0);
                GL.Vertex3(2.5f, -0.5f, 0);

                GL.Vertex3(2.5f, -0.5f, 0);
                GL.Vertex3(3.5f, 0.5f, 0);

                GL.Vertex3(3.5f, 0.5f, 0);
                GL.Vertex3(2.5f, 1.5f, 0);

                GL.Vertex3(2.5f, 1.5f, 0);
                GL.Vertex3(2.5f, 1, 0);

                GL.Vertex3(2.5f, 1, 0);
                GL.Vertex3(0, 1, 0);

                GL.Vertex3(0, 1, 0);
                GL.Vertex3(0, 0, 0);
                break;
            case 7:
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(1, 0, 0);

                GL.Vertex3(1, 0, 0);
                GL.Vertex3(2, 1, 0);
                
                GL.Vertex3(2, 1, 0);
                GL.Vertex3(-1, 1, 0);
                
                GL.Vertex3(-1, 1, 0);
                GL.Vertex3(-1, -2, 0);
                
                GL.Vertex3(-1, -2, 0);
                GL.Vertex3(0, -1, 0);
                
                GL.Vertex3(0, -1, 0);
                GL.Vertex3(0, 0, 0);
                break;
            case 8:  //Forma 8

                GL.Vertex3(0, -1, 0);
                GL.Vertex3(3, -3, 0);

                GL.Vertex3(3, -3, 0);
                GL.Vertex3(2, 0, 0);

                GL.Vertex3(2, 0, 0);
                GL.Vertex3(4, 2, 0);

                GL.Vertex3(4, 2, 0);
                GL.Vertex3(1, 2, 0);

                GL.Vertex3(1, 2, 0);
                GL.Vertex3(0, 5, 0);

                GL.Vertex3(0, 5, 0);
                GL.Vertex3(-1, 2, 0);

                GL.Vertex3(-1, 2, 0);
                GL.Vertex3(-4, 2, 0);

                GL.Vertex3(-4, 2, 0);
                GL.Vertex3(-2, 0, 0);

                GL.Vertex3(-2, 0, 0);
                GL.Vertex3(-3, -3, 0);

                GL.Vertex3(-3, -3, 0);
                GL.Vertex3(0, -1, 0);
                break;
            case 9:  //Forma 9 -------------

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(3, 0, 0);

                GL.Vertex3(3, 0, 0);
                GL.Vertex3(3, 1, 0);

                GL.Vertex3(3, 1, 0);
                GL.Vertex3(4, 1, 0);

                GL.Vertex3(4, 1, 0);
                GL.Vertex3(4, 0.5f, 0);

                GL.Vertex3(4, 0.5f, 0);
                GL.Vertex3(5, 1.5f, 0);

                GL.Vertex3(5, 1.5f, 0);
                GL.Vertex3(4, 2.5f, 0);

                GL.Vertex3(4, 2.5f, 0);
                GL.Vertex3(4, 2, 0);

                GL.Vertex3(4, 2, 0);
                GL.Vertex3(3, 2, 0);

                GL.Vertex3(3, 2, 0);
                GL.Vertex3(3, 3, 0);

                GL.Vertex3(3, 3, 0);
                GL.Vertex3(0, 3, 0);

                GL.Vertex3(0, 3, 0);
                GL.Vertex3(0, 2, 0);

                GL.Vertex3(0, 2, 0);
                GL.Vertex3(-1, 2, 0);

                GL.Vertex3(-1, 2, 0);
                GL.Vertex3(-1, 2.5f, 0);

                GL.Vertex3(-1, 2.5f, 0);
                GL.Vertex3(-2, 1.5f, 0);

                GL.Vertex3(-2, 1.5f, 0);
                GL.Vertex3(-1, 0.5f, 0);

                GL.Vertex3(-1, 0.5f, 0);
                GL.Vertex3(-1, 1, 0);

                GL.Vertex3(-1, 1, 0);
                GL.Vertex3(0, 1, 0);

                GL.Vertex3(0, 1, 0);
                GL.Vertex3(0, 0, 0);
                break;
            case 10:  //Forma 10

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(-1, 0, 0);

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(-0.9f, -1.5f, 0);

                GL.Vertex3(0.75f, 0.5f, 0);
                GL.Vertex3(-1.75f, 0.5f, 0);

                GL.Vertex3(-1.75f, 0.5f, 0);
                GL.Vertex3(-1.75f, -2, 0);

                GL.Vertex3(-1.75f, -2, 0);
                GL.Vertex3(0.75f, -2, 0);

                GL.Vertex3(0.75f, -2, 0);
                GL.Vertex3(0.75f, 0.5f, 0);
                break;
            case 11: //Forma 11

                GL.Vertex3(0, 2, 0);
                GL.Vertex3(1.2f, 2, 0);

                GL.Vertex3(1.2f, 2, 0);
                GL.Vertex3(2.2f, 1, 0);

                GL.Vertex3(2.2f, 1, 0);
                GL.Vertex3(2.2f, 0, 0);

                GL.Vertex3(2.2f, 0, 0);
                GL.Vertex3(1.2f, -1, 0);

                GL.Vertex3(1.2f, -1, 0);
                GL.Vertex3(0, -1, 0);

                GL.Vertex3(0, -1, 0);
                GL.Vertex3(-1, 0, 0);

                GL.Vertex3(-1, 0, 0);
                GL.Vertex3(-1, 1, 0);

                GL.Vertex3(-1, 1, 0);
                GL.Vertex3(0, 2, 0);

                GL.Vertex3(-0.2f, 0.2f, 0);
                GL.Vertex3(0.8f, 1.2f, 0);

                GL.Vertex3(0.8f, 1.2f, 0);
                GL.Vertex3(0.8f, -0.4f, 0);

                GL.Vertex3(-0.2f, 0.2f, 0);
                GL.Vertex3(1, 0.2f, 0);
                break;
            case 12: //Forma 12

                GL.Vertex3(0, -1, 0);
                GL.Vertex3(3, -3, 0);

                GL.Vertex3(3, -3, 0);
                GL.Vertex3(2, 0, 0);

                GL.Vertex3(2, 0, 0);
                GL.Vertex3(4, 2, 0);

                GL.Vertex3(4, 2, 0);
                GL.Vertex3(1, 2, 0);

                GL.Vertex3(1, 2, 0);
                GL.Vertex3(0, 5, 0);

                GL.Vertex3(0, 5, 0);
                GL.Vertex3(-1, 2, 0);

                GL.Vertex3(-1, 2, 0);
                GL.Vertex3(-4, 2, 0);

                GL.Vertex3(-4, 2, 0);
                GL.Vertex3(-2, 0, 0);

                GL.Vertex3(-2, 0, 0);
                GL.Vertex3(-3, -3, 0);

                GL.Vertex3(-3, -3, 0);
                GL.Vertex3(0, -1, 0);

                GL.Vertex3(-0.5f, 1, 0);
                GL.Vertex3(0, 1.5f, 0);

                GL.Vertex3(0, 1.5f, 0);
                GL.Vertex3(0, 0, 0);
                break;
            case 13:  //Forma 13

                GL.Vertex3(0, 4, 0);
                GL.Vertex3(4, 4, 0);

                GL.Vertex3(4, 4, 0);
                GL.Vertex3(4, 0, 0);

                GL.Vertex3(4, 0, 0);
                GL.Vertex3(0, 0, 0);

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0, 4, 0);

                GL.Vertex3(0.5f, 3.5f, 0);
                GL.Vertex3(3.5f, 3.5f, 0);

                GL.Vertex3(3.5f, 3.5f, 0);
                GL.Vertex3(3.5f, 0.5f, 0);

                GL.Vertex3(3.5f, 0.5f, 0);
                GL.Vertex3(0.5f, 0.5f, 0);

                GL.Vertex3(0.5f, 0.5f, 0);
                GL.Vertex3(0.5f, 3.5f, 0);

                GL.Vertex3(0, 4, 0);
                GL.Vertex3(0.5f, 3.5f, 0);

                GL.Vertex3(4, 4, 0);
                GL.Vertex3(3.5f, 3.5f, 0);

                GL.Vertex3(3.5f, 0.5f, 0);
                GL.Vertex3(4, 0, 0);

                GL.Vertex3(0.5f, 0.5f, 0);
                GL.Vertex3(0, 0, 0);
                break;
            case 14:    //Forma 14

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(1, 0, 0);

                GL.Vertex3(1, 0, 0);
                GL.Vertex3(1, -0.5f, 0);

                GL.Vertex3(1, -0.5f, 0);
                GL.Vertex3(0.5f, -0.5f, 0);

                GL.Vertex3(0.5f, -0.5f, 0);
                GL.Vertex3(1.5f, -1.5f, 0);

                GL.Vertex3(1.5f, -1.5f, 0);
                GL.Vertex3(2.5f, -0.5f, 0);

                GL.Vertex3(2.5f, -0.5f, 0);
                GL.Vertex3(2, -0.5f, 0);

                GL.Vertex3(2, -0.5f, 0);
                GL.Vertex3(2, 0, 0);

                GL.Vertex3(2, 0, 0);
                GL.Vertex3(3, 0, 0);

                GL.Vertex3(3, 0, 0);
                GL.Vertex3(3, 1, 0);

                GL.Vertex3(3, 1, 0);
                GL.Vertex3(3.5f, 1, 0);

                GL.Vertex3(3.5f, 1, 0);
                GL.Vertex3(3.5f, 0.5f, 0);

                GL.Vertex3(3.5f, 0.5f, 0);
                GL.Vertex3(4.5f, 1.5f, 0);

                GL.Vertex3(4.5f, 1.5f, 0);
                GL.Vertex3(3.5f, 2.5f, 0);

                GL.Vertex3(3.5f, 2.5f, 0);
                GL.Vertex3(3.5f, 2, 0);

                GL.Vertex3(3.5f, 2, 0);
                GL.Vertex3(3, 2, 0);

                GL.Vertex3(3, 2, 0);
                GL.Vertex3(3, 3, 0);

                GL.Vertex3(3, 3, 0);
                GL.Vertex3(2, 3, 0);

                GL.Vertex3(2, 3, 0);
                GL.Vertex3(2, 3.5f, 0);

                GL.Vertex3(2, 3.5f, 0);
                GL.Vertex3(2.5f, 3.5f, 0);

                GL.Vertex3(2.5f, 3.5f, 0);
                GL.Vertex3(1.5f, 4.5f, 0);

                GL.Vertex3(1.5f, 4.5f, 0);
                GL.Vertex3(0.5f, 3.5f, 0);

                GL.Vertex3(0.5f, 3.5f, 0);
                GL.Vertex3(1, 3.5f, 0);

                GL.Vertex3(1, 3.5f, 0);
                GL.Vertex3(1, 3, 0);

                GL.Vertex3(1, 3, 0);
                GL.Vertex3(0, 3, 0);

                GL.Vertex3(0, 3, 0);
                GL.Vertex3(0, 2, 0);

                GL.Vertex3(0, 2, 0);
                GL.Vertex3(-0.5f, 2, 0);

                GL.Vertex3(-0.5f, 2, 0);
                GL.Vertex3(-0.5f, 2.5f, 0);

                GL.Vertex3(-0.5f, 2.5f, 0);
                GL.Vertex3(-1.5f, 1.5f, 0);

                GL.Vertex3(-1.5f, 1.5f, 0);
                GL.Vertex3(-0.5f, 0.5f, 0);

                GL.Vertex3(-0.5f, 0.5f, 0);
                GL.Vertex3(-0.5f, 1, 0);

                GL.Vertex3(-0.5f, 1, 0);
                GL.Vertex3(0, 1, 0);

                GL.Vertex3(0, 1, 0);
                GL.Vertex3(0, 0, 0);
                break;
            case 15: //Forma 15

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0, 2, 0);

                GL.Vertex3(0, 2, 0);
                GL.Vertex3(2, 2, 0);

                GL.Vertex3(2, 2, 0);
                GL.Vertex3(2, 0, 0);

                GL.Vertex3(2, 0, 0);
                GL.Vertex3(0, 0, 0);

                GL.Vertex3(2, 0, 0);
                GL.Vertex3(2.5f, 0.5f, 0);

                GL.Vertex3(2.5f, 0.5f, 0);
                GL.Vertex3(2.5f, 2.5f, 0);

                GL.Vertex3(2.5f, 2.5f, 0);
                GL.Vertex3(0.5f, 2.5f, 0);

                GL.Vertex3(0.5f, 2.5f, 0);
                GL.Vertex3(0, 2, 0);

                GL.Vertex3(2, 2, 0);
                GL.Vertex3(2.5f, 2.5f, 0);
                break;
            case 16: //Forma 16

                GL.Vertex3(0, 0, 0);
                GL.Vertex3(3, 0, 0);

                GL.Vertex3(3, 0, 0);
                GL.Vertex3(3, 2, 0);

                GL.Vertex3(3, 2, 0);
                GL.Vertex3(0, 2, 0);

                GL.Vertex3(0, 2, 0);
                GL.Vertex3(0, 0, 0);

                GL.Vertex3(0, 2, 0);
                GL.Vertex3(-0.5f, 2, 0);

                GL.Vertex3(-0.5f, 2, 0);
                GL.Vertex3(1.5f, 4, 0);

                GL.Vertex3(1.5f, 4, 0);
                GL.Vertex3(3.5f, 2, 0);

                GL.Vertex3(3.5f, 2, 0);
                GL.Vertex3(3, 2, 0);

                GL.Vertex3(1.25f, 0, 0);
                GL.Vertex3(1.25f, 1, 0);

                GL.Vertex3(1.25f, 1, 0);
                GL.Vertex3(1.75f, 1, 0);

                GL.Vertex3(1.75f, 1, 0);
                GL.Vertex3(1.75f, 0, 0);

                GL.Vertex3(2.6f, 2.9f, 0);
                GL.Vertex3(2.6f, 3.75f, 0);

                GL.Vertex3(2.6f, 3.75f, 0);
                GL.Vertex3(2.1f, 3.75f, 0);

                GL.Vertex3(2.1f, 3.75f, 0);
                GL.Vertex3(2.1f, 3.4f, 0);
                break;
                //default:
                //    break;
        }
        GL.End();
        GL.PopMatrix();
    }
}