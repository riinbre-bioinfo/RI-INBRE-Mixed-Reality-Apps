using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CSVreader : MonoBehaviour
{

    public TextAsset csvFile;

    // Start is called before the first frame update
    void Start()
    {
        readCSV();
    }


    void readCSV()
    {
        string[] allLines = File.ReadAllLines(Application.dataPath + "/Scripts1/tissue_positions_list.csv");
        string[] allLinesGene = File.ReadAllLines(Application.dataPath + "/Scripts1/clusters.csv"); // for gene color file

        GameObject AllSpheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);

       
       


            foreach (string s in allLines)

        {
            string[] splitData = s.Split(',');


            if (int.Parse(splitData[1]) == 1)
            {
                GameObject gene = GameObject.CreatePrimitive(PrimitiveType.Sphere);
           
                gene.transform.parent = AllSpheres.transform;
                gene.transform.position = new Vector3(int.Parse(splitData[2]) *.02f -10.5f, int.Parse(splitData[3]) *0.01f +6, -37.5f);
                gene.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                int geneCluster = 10;

                foreach (string sGene in allLinesGene)
                {
                    string[] splitDataGene = sGene.Split(',');

                    if(splitDataGene[0] == splitData[0])
                    {
                        geneCluster = int.Parse(splitDataGene[1]);
                        break;
                    }
                }



                if (geneCluster == 1)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(0,0,255); // blue
                } else if (geneCluster == 2)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(255, 165, 0); //orange
                }
                else if (geneCluster == 3)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(0, 255, 0); //lime
                }
                else if (geneCluster == 4)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(255, 0, 0); //red
                }
                else if (geneCluster == 5)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(128, 0, 128); //purple
                }
                else if (geneCluster == 6)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(165, 42, 42); //brown
                }
                else if (geneCluster == 7)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(255, 192, 203); //pink
                }
                else if (geneCluster == 8)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(255, 255, 0); //yellow
                }
                else if (geneCluster == 9)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(191, 231, 255);//light blue
                }
                else if (geneCluster == 10)
                {
                    gene.GetComponent<Renderer>().material.color = new Color(0, 0, 0); // black 
                }  



            }

       

            


        }
        AllSpheres.transform.position = new Vector3(28.46f, -3.23f, -32.78f);
        AllSpheres.transform.Rotate(0, 90, -90, Space.Self);

    }
}
