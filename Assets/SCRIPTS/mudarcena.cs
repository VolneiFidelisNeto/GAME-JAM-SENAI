
using UnityEngine;
using UnityEngine.SceneManagement;
public class mudarcena : MonoBehaviour
{ 
        public void TrocarCena()
    {
        SceneManager.LoadScene(1);
    }
        public void IrParaConfig()
    {
        SceneManager.LoadScene(2);
    }
        public void SairConfig()
    {
        SceneManager.LoadScene(0);
    }
}
