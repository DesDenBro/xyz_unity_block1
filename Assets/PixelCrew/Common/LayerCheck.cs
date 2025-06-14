﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew.Common
{
    public class LayerCheck : MonoBehaviour
    {
        [SerializeField] private LayerMask _groundLayer;

        private Collider2D _collider;
        private bool _isTouchingLayer;

        public bool IsTouchingLayer => _isTouchingLayer;

        public void Awake()
        {
            _collider = GetComponent<Collider2D>();
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            _isTouchingLayer = _collider.IsTouchingLayers(_groundLayer);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            _isTouchingLayer = _collider.IsTouchingLayers(_groundLayer);
        }
    }
}
