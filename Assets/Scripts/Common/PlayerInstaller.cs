using UnityEngine;
using Zenject;

namespace Common
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player _player;
        [SerializeField] private Transform _playerSpawnPoint;

        public override void InstallBindings()
        {
            var playerInstance = Container.InstantiatePrefabForComponent<Player>(
                _player, _playerSpawnPoint.position, Quaternion.identity, null);

            Container.Bind<Player>().FromInstance(playerInstance).AsSingle().NonLazy();
        }
    }
}