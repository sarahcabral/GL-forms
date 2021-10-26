using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Atividade2 : MonoBehaviour
{
    public Material mat;
    public int op;
    public float radius = 2f;

    private void Draw_tri(Vector3 p1, Vector3 p2, Vector3 p3)
    {
        GL.PushMatrix();
        mat.SetPass(0);
        GL.Begin(GL.LINES);

        GL.Vertex3(p1.x, p1.y, p1.z);
        GL.Vertex3(p2.x, p2.y, p2.z);

        GL.Vertex3(p2.x, p2.y, p2.z);
        GL.Vertex3(p3.x, p3.y, p3.z);

        GL.Vertex3(p3.x, p3.y, p3.z);
        GL.Vertex3(p1.x, p1.y, p1.z);

        GL.End();

        GL.PopMatrix();
        return;
    }

    private void OnPostRender()    {

        Vector3 center = new Vector3(0, 0, 0);
        GL.PushMatrix();
        mat.SetPass(0);
        GL.Color(Color.yellow);

        switch(op)
        {
            case 1:
                GL.PushMatrix();
                mat.SetPass(0);
                GL.Begin(GL.LINES);
                for (float t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();
                GL.PopMatrix();

                break;

            case 2:
                GL.PushMatrix();
                mat.SetPass(0);
                GL.Begin(GL.LINES);
                for (float t = 0; t < (Mathf.PI * 2); t += 0.01f)
                {
                    Vector3 ci = (new Vector3((Mathf.Cos(t) * radius + center.x), (Mathf.Sin(t) * radius + center.y) / 2, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();
                GL.Begin(GL.LINES);
                GL.Vertex3(radius, 0, 0);
                GL.Vertex3(radius, -(2 * radius), 0);
                GL.Vertex3(-radius, 0, 0);
                GL.Vertex3(-radius, -(2 * radius), 0);
                GL.End();

                GL.Begin(GL.LINES);

                float y_base = radius * 3.89f;

                center = new Vector3(0, -y_base, 0);
                
                for (float t = Mathf.PI; t < (Mathf.PI * 2); t += 0.01f)
                {
                    Vector3 ci = (new Vector3((Mathf.Cos(t) * radius + center.x), (Mathf.Sin(t) * radius + center.y) / 2, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();
                GL.PopMatrix();
                break;

            case 3:
                GL.PushMatrix();
                mat.SetPass(0);
                GL.Begin(GL.LINES);
                for (float t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                float radius_center = radius - (radius * 0.3f);
                GL.PushMatrix();
                mat.SetPass(0);
                GL.Begin(GL.LINES);
                for (float t = 2.61f; t < 5.24f; t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius_center + center.x, Mathf.Sin(t) * radius_center + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);
                for (float t = 5.76f; t < (2 * Mathf.PI) + 2.09f; t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius_center + center.x, Mathf.Sin(t) * radius_center + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();
                
                Vector3 p1_l1 = (new Vector3(Mathf.Cos(2.61f) * radius_center + center.x, Mathf.Sin(2.61f) * radius_center + center.y, center.z));
                Vector3 p2_l1 = (new Vector3(Mathf.Cos(5.24f) * radius_center + center.x, Mathf.Sin(5.24f) * radius_center + center.y, center.z));
                Vector3 p1_l2 = (new Vector3(Mathf.Cos(5.76f) * radius_center + center.x, Mathf.Sin(5.76f) * radius_center + center.y, center.z));
                Vector3 p2_l2 = (new Vector3(Mathf.Cos((2 * Mathf.PI) + 2.09f) * radius_center + center.x, Mathf.Sin((2 * Mathf.PI) + 2.09f) * radius_center + center.y, center.z));
                
                GL.Begin(GL.LINES);
                                        
                GL.Vertex3(p1_l1.x, p1_l1.y, p1_l1.z);
                GL.Vertex3(p2_l1.x, p2_l1.y, p2_l1.z);
                           
                GL.Vertex3(p1_l2.x, p1_l2.y, p1_l2.z);
                GL.Vertex3(p2_l2.x, p2_l2.y, p2_l2.z);
                GL.End();
                GL.PopMatrix(); 

                break;
            case 4:
                GL.PushMatrix();
                mat.SetPass(0);

                GL.Begin(GL.LINES);

                float x_olho = radius - (radius * 0.56f);
                float y_olho = radius - (radius * 0.6f);

                center = new Vector3(-x_olho, y_olho, 0);

                float radius_eye = radius - (radius * 0.87f);

                if (radius <= 0)
                    radius = 0.1f;

                for (float t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius_eye + center.x, Mathf.Sin(t) * radius_eye + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);

                center = new Vector3(x_olho, y_olho, 0);

                for(float t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius_eye + center.x, Mathf.Sin(t) * radius_eye + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);
                center = new Vector3(0, 0, 0);

                float radius_smile = radius - (radius * 0.37f);

                if (radius <= 0)
                    radius = 0.1f;

                //Teste para dar risada:
                //center = new Vector3(0, -3, 0);
                //for (float t = (Mathf.PI / 4) * 4; t < (Mathf.PI / 4) * 7; t += 0.01f)
                //{
                //    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius_smile + center.x, (Mathf.Sin(t) * radius_smile + center.y )/ 2, center.z));
                //    GL.Vertex3(ci.x, ci.y, ci.z);
                //}

                for (float t = (Mathf.PI / 4) * 5; t < (Mathf.PI / 4) * 7; t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius_smile + center.x, Mathf.Sin(t) * radius_smile + center.y , center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);

                for (float t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();
                GL.PopMatrix();
                break;

            case 5:
                GL.PushMatrix();
                mat.SetPass(0);

                GL.Begin(GL.LINES);
                for (float t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);
                GL.Vertex3(radius, 0, 0);
                GL.Vertex3(-radius, 0, 0);

                GL.Vertex3(0, radius, 0);
                GL.Vertex3(0, -radius, 0);
                GL.End();

                GL.PopMatrix();
                break;

            case 6:
                GL.PushMatrix();
                mat.SetPass(0);

                GL.Begin(GL.LINES);
                for (float t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);
                float radius_base = radius + (radius * 0.15f);
                float radius_topo = (radius * 1.9f);

                for (float t = 0.0f; t < (2 * Mathf.PI); t += (Mathf.PI / 4))
                {
                    
                    Vector3 t1 = (new Vector3(  Mathf.Cos(t - (Mathf.PI / 12)) * radius_base + center.x, 
                                                Mathf.Sin(t - (Mathf.PI / 12)) * radius_base + center.y, 
                                                center.z));

                    Vector3 t2 = (new Vector3(Mathf.Cos(t + (Mathf.PI / 12)) * radius_base + center.x,
                                                Mathf.Sin(t + (Mathf.PI / 12)) * radius_base + center.y,
                                                center.z));

                    Vector3 t3 = (new Vector3(  Mathf.Cos(t) * radius_topo + center.x, 
                                                Mathf.Sin(t) * radius_topo + center.y, 
                                                center.z));

                    Draw_tri(t1, t2, t3);

                }

                GL.End();
                GL.PopMatrix();
                break;
            case 7:
                GL.PushMatrix();
                mat.SetPass(0);
                               
                float larg = radius * 4;
                float altura = radius * 2.4f;
                
                GL.Begin(GL.LINES);
                center = new Vector3(-larg, altura, 0);
                for (float t = (Mathf.PI / 2); t < Mathf.PI; t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);

                center = new Vector3(larg, -altura, 0);
                for (float t = 3 * (Mathf.PI / 2); t < (2 * Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();

                GL.Begin(GL.LINES);
                
                GL.Vertex3((larg + radius), (altura + radius), 0);
                GL.Vertex3((larg + radius), -altura, 0);
                  
                GL.Vertex3(larg, -altura - radius, 0);
                GL.Vertex3(-larg - radius, -altura - radius, 0);

                GL.Vertex3(-larg - radius, -altura - radius, 0);
                GL.Vertex3(-larg - radius, altura, 0);

                GL.Vertex3(-larg, altura + radius, 0); 
                GL.Vertex3(larg + radius, altura + radius, 0);

                GL.End();
                GL.PopMatrix();
                break;

        }
    }

    
}
