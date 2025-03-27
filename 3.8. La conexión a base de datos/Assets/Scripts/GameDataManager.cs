using UnityEngine;
using Firebase.Firestore;
using Firebase.Extensions;
using System.Collections.Generic;

public class GameDataManager : MonoBehaviour
{
    FirebaseFirestore db;

    private void Start()
    {
        db = FirebaseFirestore.DefaultInstance;
    }

    public void GuardarProgreso(string jugadorID, int monedas, int nivel1, int nivel2)
    {
        DocumentReference docRef = db.Collection("jugadores").Document(jugadorID);
        Dictionary<string, object> datos = new Dictionary<string, object>
        {
            { "monedas", monedas },
            { "nivel1", nivel1 },
            { "nivel2", nivel2 }
        };

        docRef.SetAsync(datos).ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted)
                Debug.Log("✅ Progreso guardado en Firebase.");
            else
                Debug.LogError("❌ Error al guardar: " + task.Exception);
        });
    }
}
