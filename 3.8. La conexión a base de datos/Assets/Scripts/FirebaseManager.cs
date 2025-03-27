using UnityEngine;
using Firebase;
using Firebase.Firestore;
using Firebase.Extensions;

public class FirebaseManager  : MonoBehaviour
{
    public FirebaseFirestore db;

    private void Awake()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                FirebaseApp app = FirebaseApp.DefaultInstance;
                db = FirebaseFirestore.DefaultInstance;
                Debug.Log("✅ Firebase Firestore conectado correctamente.");
            }
            else
            {
                Debug.LogError("❌ Error al conectar Firebase: " + task.Result);
            }
        });

        Debug.Log("🔥 FirebaseManager se está ejecutando...");
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                FirebaseApp app = FirebaseApp.DefaultInstance;
                db = FirebaseFirestore.DefaultInstance;
                Debug.Log("✅ Firebase Firestore conectado correctamente.");
            }
            else
            {
                Debug.LogError("❌ Error al conectar Firebase: " + task.Result);
            }
        });
    }
  
}

