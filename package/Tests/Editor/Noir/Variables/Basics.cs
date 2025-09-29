using Moq;
using NExpect;
using Noir.Testing;
using Noir.Variables;
using NUnit.Framework;
using System.Collections.Generic;
using static NExpect.Expectations;

namespace NoirEditModeTests.Noir.Variables {
    public class VariableBasics : NoirTestCase {
        [Test]
        public void WhenChangingAVariable_TheEventsFireInTheCorrectOrder() {
            var testVariable = ScriptableObject.CreateInstance<IntVariable>();
            testVariable.TrySetValue(10, silently: true);

            var ordering = new List<string>();
            
            testVariable.OnBeforeVariableChanged += () => ordering.Add("OnBeforeVariableChanged");
            testVariable.OnDataVariableChanged += () => ordering.Add("OnDataVariableChanged");
            testVariable.OnAfterVariableChanged += () => ordering.Add("OnAfterVariableChanged");
            
            testVariable.Value = 1;
            
            Expect(ordering.Length).To.Equal(3);
            Expect(ordering[0]).To.Equal("OnBeforeVariableChanged");
            Expect(ordering[1]).To.Equal("OnDataVariableChanged");
            Expect(ordering[2]).To.Equal("OnAfterVariableChanged");
        }
    }
}
