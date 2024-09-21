/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Database
{
    #region CrossProcessCursorWrapper declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/database/CrossProcessCursorWrapper.html"/>
    /// </summary>
    public partial class CrossProcessCursorWrapper : Android.Database.CursorWrapper
    {
        const string _bridgeClassName = "android.database.CrossProcessCursorWrapper";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CrossProcessCursorWrapper() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CrossProcessCursorWrapper(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region CrossProcessCursorWrapper implementation
    public partial class CrossProcessCursorWrapper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CrossProcessCursorWrapper.html#%3Cinit%3E(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public CrossProcessCursorWrapper(Android.Database.Cursor arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Database.CrossProcessCursorWrapper"/> to <see cref="Android.Database.CrossProcessCursor"/>
        /// </summary>
        public static implicit operator Android.Database.CrossProcessCursor(Android.Database.CrossProcessCursorWrapper t) => t.Cast<Android.Database.CrossProcessCursor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CrossProcessCursorWrapper.html#getWindow()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.CursorWindow"/></returns>
        public Android.Database.CursorWindow GetWindow()
        {
            return IExecuteWithSignature<Android.Database.CursorWindow>("getWindow", "()Landroid/database/CursorWindow;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CrossProcessCursorWrapper.html#onMove(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnMove(int arg0, int arg1)
        {
            return IExecute<bool>("onMove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CrossProcessCursorWrapper.html#fillWindow(int,android.database.CursorWindow)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Database.CursorWindow"/></param>
        public void FillWindow(int arg0, Android.Database.CursorWindow arg1)
        {
            IExecute("fillWindow", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}