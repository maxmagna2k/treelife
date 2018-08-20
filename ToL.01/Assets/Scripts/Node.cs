using UnityEngine;
using System.Collections;

namespace Topology
{

    public class Node : MonoBehaviour
    {

        public string id;
        public TextMesh nodeText;

        void Update()
        {
            //node text always facing camera
            nodeText.transform.LookAt(Camera.main.transform);
        }
    }

}