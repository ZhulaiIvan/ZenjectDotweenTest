using UnityEngine;
using Zenject;

namespace Common
{
    public class EnemyInstaller : MonoInstaller
    {
        [SerializeField] private Enemy _enemy;
        [SerializeField] private Transform _enemySpawnPoint;

        public override void InstallBindings()
        {
            var enemyInstance = Container.InstantiatePrefabForComponent<Enemy>(
                _enemy, _enemySpawnPoint.position, Quaternion.identity, null);

            Container.Bind<Enemy>().FromInstance(enemyInstance).AsSingle().NonLazy();
        }
    }
}
