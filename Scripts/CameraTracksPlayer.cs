using UnityEngine;
using System.Collections;

public class CameraTracksPlayer : MonoBehaviour {

    Transform player;

    void Start()
    {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        if (player_go == null)
        {
            Debug.LogError("Não foi encontrado nenhum objeto com a tag PLayer");
        }
        player = player_go.transform;
    }
}
