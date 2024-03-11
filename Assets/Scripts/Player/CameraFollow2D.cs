using UnityEngine;

    public class CameraFollow2D : MonoBehaviour
    {
        [Header("Parameters")]
        public Transform playerTransform;
        public string playerTag;
        [Range(0.5f, 7.5f)] public float movingSpeed = 3.5f;

        private void Awake()
        {
            if (playerTransform == null)
            {
                if (playerTag == "")
                {
                    playerTag = "Player";
                }
                playerTransform = GameObject.FindGameObjectWithTag(playerTag).transform;
            } // поиск объекта если он не был добавлен изначально в поле трансформ
        
            transform.position = new Vector3() // присваивание камере позиции найденого персонажа
            {
                x = playerTransform.position.x,
                y = playerTransform.position.y,
                z = playerTransform.position.z - 10, // Отнимаем 10 единиц чтобы камера была позади игрока
            };
        }

        private void Update() // в Update проверяется есть ли движение, если есть камере назначаем новую позицию
        {
            if (playerTransform)
            {
                Vector3 target = new Vector3()
                {
                    x = playerTransform.position.x,
                    y = playerTransform.position.y,
                    z = playerTransform.position.z - 10,
                };

                Vector3 pos = Vector3.Lerp(transform.position, target, movingSpeed * Time.deltaTime);

                transform.position = pos;
            }
        }
    
    }

