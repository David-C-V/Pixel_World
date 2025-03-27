using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameDataManager gameDataManager;

    private void Start()
    {
        // Buscar el GameDataManager en la escena
        gameDataManager = FindObjectOfType<GameDataManager>();

        // Si el GameDataManager no está encontrado, mostrar un mensaje
        if (gameDataManager == null)
        {
            Debug.LogError("No se encontró GameDataManager en la escena");
            return;
        }

        // Llamar a la función para guardar datos
        GuardarDatosDeJugador();
    }

    private void GuardarDatosDeJugador()
    {
        // Usar un ejemplo de ID de jugador y datos
        string jugadorID = "Jugador123"; // Aquí podrías poner el ID real del jugador
        int monedas = 250;
        int nivel1 = 1;
        int nivel2 = 2;

        // Llamar a la función GuardarProgreso de GameDataManager
        gameDataManager.GuardarProgreso(jugadorID, monedas, nivel1, nivel2);
    }
}
