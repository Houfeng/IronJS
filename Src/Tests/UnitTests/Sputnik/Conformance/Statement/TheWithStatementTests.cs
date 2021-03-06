// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Statement
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheWithStatementTests : SputnikTestFixture
    {
        public TheWithStatementTests()
            : base(@"Conformance\12_Statement\12.10_The_with_Statement")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.10")]
        [TestCase("S12.10_A1.1_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.1_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.1_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.10_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.10_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.10_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.10_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.10_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.11_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.11_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.11_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.11_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.11_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.12_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.12_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.12_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.12_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.12_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.2_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.2_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.2_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.2_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.2_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.3_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.3_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.3_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.3_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.3_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.4_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.4_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.4_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.4_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.4_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.5_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.5_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.5_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.5_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.5_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.6_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.6_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.6_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.7_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.7_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.7_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.7_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.7_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.8_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.8_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.8_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.8_T4.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.8_T5.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.9_T1.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.9_T2.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        [TestCase("S12.10_A1.9_T3.js", Description = "The with statement adds a computed object to the front of the scope chain of the current execution context")]
        public void TheWithStatementAddsAComputedObjectToTheFrontOfTheScopeChainOfTheCurrentExecutionContext(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.10")]
        [TestCase("S12.10_A3.1_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.1_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.1_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.10_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.10_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.10_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.10_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.10_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.11_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.11_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.11_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.11_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.11_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.12_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.12_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.12_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.12_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.12_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.2_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.2_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.2_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.2_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.2_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.3_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.3_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.3_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.3_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.3_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.4_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.4_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.4_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.4_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.4_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.5_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.5_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.5_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.5_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.5_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.6_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.6_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.6_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.7_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.7_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.7_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.7_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.7_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.8_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.8_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.8_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.8_T4.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.8_T5.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.9_T1.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.9_T2.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        [TestCase("S12.10_A3.9_T3.js", Description = "No matter how control leaves the embedded \'Statement\', the scope chain is always restored to its former state")]
        public void NoMatterHowControlLeavesTheEmbeddedStatementTheScopeChainIsAlwaysRestoredToItsFormerState(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.10")]
        [TestCase("S12.10_A4_T1.js", Description = "Changing property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A4_T2.js", Description = "Changing property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A4_T3.js", Description = "Changing property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A4_T4.js", Description = "Changing property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A4_T5.js", Description = "Changing property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A4_T6.js", Description = "Changing property using \"eval\" statement containing \"with\" statement")]
        public void ChangingPropertyUsingEvalStatementContainingWithStatement(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.10")]
        [TestCase("S12.10_A5_T1.js", Description = "Deleting property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A5_T2.js", Description = "Deleting property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A5_T3.js", Description = "Deleting property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A5_T4.js", Description = "Deleting property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A5_T5.js", Description = "Deleting property using \"eval\" statement containing \"with\" statement")]
        [TestCase("S12.10_A5_T6.js", Description = "Deleting property using \"eval\" statement containing \"with\" statement")]
        public void DeletingPropertyUsingEvalStatementContainingWithStatement(string file)
        {
            RunFile(file);
        }
    }
}