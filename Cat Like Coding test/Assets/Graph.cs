using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
   [SerializeField]
   public Transform pointPrefab;

    [Range(10,100)]
    public int Resolution = 10;

Transform[] points;
   void Awake()
   {
       float step = 2f / Resolution;
       Vector3 position;
       Vector3 scale = Vector3.one * step;
		position.y = 0f;
		position.z = 0f;

        points = new Transform[Resolution];
       for(int x=0; x< points.Length; x++)
       {

      Transform point =  Instantiate(pointPrefab);

        points[x] = point;
            position.x = (x + 0.5f) * step - 1f;
           // position.y = position.x * position.x;
			point.localPosition = position;
			point.localScale = scale;
            point.SetParent(transform,false);
       }

   }

   private void Update() {
       for(int i =0; i<points.Length; i++)
       {
           Transform point = points[i];
           Vector3 position = point.localPosition;
           position.y = Mathf.Sin(Mathf.PI * (position.x + Time.time));  point.localPosition = position;
       }
   }
}
