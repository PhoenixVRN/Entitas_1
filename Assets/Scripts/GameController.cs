using UnityEngine;

public class GameController : MonoBehaviour
{
    RootSystems _sysrems;
    void Start()
    {
        _sysrems = new RootSystems(Contexts.sharedInstance);

        _sysrems.Initialize();
    }

    
    void Update()
    {
        _sysrems.Execute();
    }
}
