using HoldfastSharedMethods;
using UnityEngine;

namespace eLF_AutoAdmin
{
    public struct playerStruct
    {
        public FactionCountry _playerFaction;
        public PlayerClass _playerClass;
        public int _uniformId;
        public GameObject _playerObject;
        public bool _isAlive;

        public shotStruct shotInfo;
    }
}