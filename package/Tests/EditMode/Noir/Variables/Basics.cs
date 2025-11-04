using Moq;
using NExpect;
using Noir.Testing;
using Noir.Variables;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static NExpect.Expectations;

namespace NoirEditModeTests.Noir.Variables {
    public class VariableBasics : NoirEditModeTestCase {
        [Test]
        public void WhenChangingAVariable_TheEventsFireInTheCorrectOrder() {
            var testVariable = ScriptableObject.CreateInstance<IntVariable>();
            testVariable.TrySetValue(10, silently: true);

            var ordering = new List<string>();
            
            testVariable.OnBeforeVariableChanged += () => ordering.Add("OnBeforeVariableChanged");
            testVariable.OnDataVariableChanged += (int oldValue, int newValue) => ordering.Add("OnDataVariableChanged");
            testVariable.OnAfterVariableChanged += () => ordering.Add("OnAfterVariableChanged");
            
            testVariable.Value = 1;
            
            Expect(ordering.Count).To.Equal(3);
            Expect(ordering[0]).To.Equal("OnBeforeVariableChanged");
            Expect(ordering[1]).To.Equal("OnDataVariableChanged");
            Expect(ordering[2]).To.Equal("OnAfterVariableChanged");
        }

        [Test]
        public async Task WhenChangingAVariable_OnDataVariableChangedIsCalledWithTheOldAndNewValue() {
            var testVariable = ScriptableObject.CreateInstance<IntVariable>();
            testVariable.TrySetValue(10, silently: true);

            int oldValue = 0, newValue = 0;
            testVariable.OnDataVariableChanged += (int oldVal, int newVal) => {
                oldValue = oldVal;
                newValue = newVal;
            };
            
            testVariable.Value = 20;

            await Task.Delay(200);
            
            Expect(oldValue).To.Equal(10);
            Expect(newValue).To.Equal(20);
        }
    }
}
