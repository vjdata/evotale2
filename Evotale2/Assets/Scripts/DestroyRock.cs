using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DestroyRock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var ethan = other.gameObject.FindChildrenByTag("Ethan").FirstOrDefault();
            var ogre = other.gameObject.FindChildrenByTag("Ogre").FirstOrDefault();

            if (ogre.activeSelf)
            {
                Destroy(this.gameObject);
            }
        }
    }
}


public static class TransformExtensions
{
    /// <summary>
    /// Find all children of the Transform by tag (includes self)
    /// </summary>
    /// <param name="transform"></param>
    /// <param name="tags"></param>
    /// <returns></returns>
    public static List<Transform> FindChildrenByTag(this Transform transform, params string[] tags)
    {
        List<Transform> list = new List<Transform>();
        foreach (var tran in transform.Cast<Transform>().ToList())
            list.AddRange(tran.FindChildrenByTag(tags)); // recursively check children
        if (tags.Any(tag => tag == transform.tag))
            list.Add(transform); // we matched, add this transform
        return list;
    }

    /// <summary>
    /// Find all children of the GameObject by tag (includes self)
    /// </summary>
    /// <param name="gameObject"></param>
    /// <param name="tags"></param>
    /// <returns></returns>
    public static List<GameObject> FindChildrenByTag(this GameObject gameObject, params string[] tags)
    {
        return FindChildrenByTag(gameObject.transform, tags)
            //.Cast<GameObject>() // Can't use Cast here :(
            .Select(tran => tran.gameObject)
            .Where(gameOb => gameOb != null)
            .ToList();
    }
}