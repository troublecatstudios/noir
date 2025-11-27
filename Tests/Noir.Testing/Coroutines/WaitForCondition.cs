using Noir.Abstractions;
using NUnit.Framework;
using System;
using UnityEngine;

namespace Noir.Testing.Coroutines {
    public class WaitForCondition : CustomYieldInstruction {
        private Func<bool> _expression;
        private float _maxTime;
        private readonly IGameTime _time;
        private float _startTime = 0f;
        private bool _assert = false;
        private bool _debug = false;
        private float _timeTaken;
        private bool _result;

        public WaitForCondition(IGameTime time = null, bool assert = false, bool debug = false) {
            _time = time ?? new GameTime();
            _startTime = _time.realtimeSinceStartup;
            _assert = assert;
            _debug = debug;

            if (debug) {
                Debug.Log($"WaitForCondition created. maxTime={_maxTime}, assert={_assert}");
            }
        }

        public float TimeTaken => _timeTaken;

        public Func<bool> Expression {
            set { _expression = value; }
        }

        public float MaxTime {
            set { _maxTime = value; }
        }

        public bool Result => _result;

        public bool IsComplete { get; private set; }

        public string AssertFailureMessage { get; set; }

        public override void Reset() {
            base.Reset();
            _result = false;
            _startTime = _time.realtimeSinceStartup;
            IsComplete = false;
        }

        public override bool keepWaiting => Evaluate();

        private bool Evaluate() {
            _result = _expression();
            _timeTaken = _time.realtimeSinceStartup - _startTime;
            if (_timeTaken > _maxTime || _result) {
                if (_debug) {
                    Debug.Log($"Evaluate keepWaiting=false, result={_result}, timeTaken={_timeTaken}, maxTime={_maxTime}, assert={_assert}");
                }
                if (_assert) {
                    Assert.That(_result, Is.True, AssertFailureMessage ?? $"Condition did not evaluate to true after {_maxTime}s.");
                }
                IsComplete = true;
                return false;
            }
            if (_debug) {
                Debug.Log($"Evaluate keepWaiting=true, result={_result}, timeTaken={_timeTaken}, maxTime={_maxTime}");
            }
            return true;
        }
    }
}