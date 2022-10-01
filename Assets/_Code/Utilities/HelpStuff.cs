
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Class with public static funcs
public static class GlobalHelpers
{
    // Use: transform.ShowMyName();
    public static void ShowMyName(this Transform t) => Debug.Log(t.name);
    // Use: transform.ShowMyPosition();
    public static void ShowMyPosition(this Transform t) => Debug.Log(t.position);

    // Use: transform.ActiveChildren();
    public static void ActiveChildren(this Transform t) => ChangeActiveChildren(t, true);

    // Use: transform.DeactiveChildren();
    public static void DeactiveChildren(this Transform t) => ChangeActiveChildren(t, false);

    // Use: transform.DeactiveChildren();
    public static void ChangeActiveChildren(this Transform t, bool active)
    {
        foreach (Transform child in t) child.gameObject.SetActive(active);
    }

    // Use: transform.DestroyChildren();
    public static void DestroyChildren(this Transform t)
    {
        foreach (Transform child in t) Object.Destroy(child.gameObject);
    }
}

namespace Kerioth.Stuff
{
    //Class for mouse pointer operations
    public class Pointer
    {

        public static Vector3 GetPointerWorldPosition2D()
        {
            return GetPointerWorldPosition2D(Camera.main);
        }

        public static Vector3 GetPointerWorldPosition2D(Camera camera)
        {
            Vector3 v3 = GetPointerWorldPosition3D(Input.mousePosition, camera);
            v3.z = 0f;
            return v3;
        }

        public static Vector3 GetPointerWorldPosition3D()
        {
            return GetPointerWorldPosition3D(Input.mousePosition, Camera.main);
        }

        public static Vector3 GetPointerWorldPosition3D(Camera camera)
        {
            return GetPointerWorldPosition3D(Input.mousePosition, camera);
        }

        public static Vector3 GetPointerWorldPosition3D(Vector3 screenPos, Camera camera)
        {
            Vector3 worldPos = camera.ScreenToWorldPoint(screenPos);
            return worldPos;
        }
    }

    // Class for easy scene managment
    public class Loader
    {
        public static void Load(int scene) => SceneManager.LoadScene(scene);

        public static void Load(string scene) => SceneManager.LoadScene(scene);

        public static void Reload() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        public static void NextScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Class for get an angle from something
    public class Angle
    {
        public static float GetFromVector(Vector3 dir)
        {
            dir = dir.normalized;
            float n = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            if (n < 0) n += 360;

            return n;
        }
    }
    
}