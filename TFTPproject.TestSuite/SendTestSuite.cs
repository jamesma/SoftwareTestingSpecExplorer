//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TFTPproject.TestAdapter {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3130.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SendTestSuite : VsTestClassBase {
        
        public SendTestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Test Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize() {
            this.InitializeTestManager();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestCleanup() {
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS0() {
            this.Manager.BeginTest("SendTestSuiteS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call sendReadRequestAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendReadRequestAdapter();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return sendReadRequestAdapter\'");
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S18\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S24\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S36\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S42\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S48\'");
            bool temp0;
            this.Manager.Comment("executing step \'call canGetExitAdapter(0)\'");
            temp0 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(0);
            this.Manager.Comment("reaching state \'S54\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/True\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp0, "return of canGetExitAdapter, state S54");
            this.Manager.Comment("reaching state \'S60\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S10
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS10() {
            this.Manager.BeginTest("SendTestSuiteS10");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("executing step \'call sendReadRequestAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendReadRequestAdapter();
            this.Manager.Comment("reaching state \'S11\'");
            this.Manager.Comment("checking step \'return sendReadRequestAdapter\'");
            this.Manager.Comment("reaching state \'S17\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S23\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S29\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S35\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S47\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S53\'");
            bool temp1;
            this.Manager.Comment("executing step \'call canGetExitAdapter(1024)\'");
            temp1 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(1024);
            this.Manager.Comment("reaching state \'S59\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp1, "return of canGetExitAdapter, state S59");
            this.Manager.Comment("reaching state \'S65\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S68\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S71\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S74\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S77\'");
            bool temp2;
            this.Manager.Comment("executing step \'call canGetExitAdapter(0)\'");
            temp2 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(0);
            this.Manager.Comment("reaching state \'S80\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/True\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp2, "return of canGetExitAdapter, state S80");
            this.Manager.Comment("reaching state \'S83\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS2() {
            this.Manager.BeginTest("SendTestSuiteS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call sendReadRequestAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendReadRequestAdapter();
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return sendReadRequestAdapter\'");
            this.Manager.Comment("reaching state \'S13\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S19\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S25\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S37\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S43\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S49\'");
            bool temp3;
            this.Manager.Comment("executing step \'call canGetExitAdapter(8)\'");
            temp3 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(8);
            this.Manager.Comment("reaching state \'S55\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/True\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp3, "return of canGetExitAdapter, state S55");
            this.Manager.Comment("reaching state \'S61\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS4() {
            this.Manager.BeginTest("SendTestSuiteS4");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call sendReadRequestAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendReadRequestAdapter();
            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("checking step \'return sendReadRequestAdapter\'");
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S26\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S32\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S38\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S44\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S50\'");
            bool temp4;
            this.Manager.Comment("executing step \'call canGetExitAdapter(508)\'");
            temp4 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(508);
            this.Manager.Comment("reaching state \'S56\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/True\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp4, "return of canGetExitAdapter, state S56");
            this.Manager.Comment("reaching state \'S62\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S6
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS6() {
            this.Manager.BeginTest("SendTestSuiteS6");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call sendReadRequestAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendReadRequestAdapter();
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return sendReadRequestAdapter\'");
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S27\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S33\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S39\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S45\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S51\'");
            bool temp5;
            this.Manager.Comment("executing step \'call canGetExitAdapter(512)\'");
            temp5 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(512);
            this.Manager.Comment("reaching state \'S57\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp5, "return of canGetExitAdapter, state S57");
            this.Manager.Comment("reaching state \'S63\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S66\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S69\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S72\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S75\'");
            bool temp6;
            this.Manager.Comment("executing step \'call canGetExitAdapter(0)\'");
            temp6 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(0);
            this.Manager.Comment("reaching state \'S78\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/True\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp6, "return of canGetExitAdapter, state S78");
            this.Manager.Comment("reaching state \'S81\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S8
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS8() {
            this.Manager.BeginTest("SendTestSuiteS8");
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("executing step \'call sendReadRequestAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendReadRequestAdapter();
            this.Manager.Comment("reaching state \'S9\'");
            this.Manager.Comment("checking step \'return sendReadRequestAdapter\'");
            this.Manager.Comment("reaching state \'S16\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S22\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S28\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S34\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S40\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S46\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S52\'");
            bool temp7;
            this.Manager.Comment("executing step \'call canGetExitAdapter(516)\'");
            temp7 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(516);
            this.Manager.Comment("reaching state \'S58\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp7, "return of canGetExitAdapter, state S58");
            this.Manager.Comment("reaching state \'S64\'");
            this.Manager.Comment("executing step \'call sendACKAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.sendACKAdapter();
            this.Manager.Comment("reaching state \'S67\'");
            this.Manager.Comment("checking step \'return sendACKAdapter\'");
            this.Manager.Comment("reaching state \'S70\'");
            this.Manager.Comment("executing step \'call receiveDataBlockAdapter()\'");
            TFTPproject.TestAdapter.TestAdapter.receiveDataBlockAdapter();
            this.Manager.Comment("reaching state \'S73\'");
            this.Manager.Comment("checking step \'return receiveDataBlockAdapter\'");
            this.Manager.Comment("reaching state \'S76\'");
            bool temp8;
            this.Manager.Comment("executing step \'call canGetExitAdapter(0)\'");
            temp8 = TFTPproject.TestAdapter.TestAdapter.canGetExitAdapter(0);
            this.Manager.Comment("reaching state \'S79\'");
            this.Manager.Comment("checking step \'return canGetExitAdapter/True\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp8, "return of canGetExitAdapter, state S79");
            this.Manager.Comment("reaching state \'S82\'");
            this.Manager.EndTest();
        }
        #endregion
    }
}
