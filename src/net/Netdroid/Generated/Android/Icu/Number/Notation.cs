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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Number
{
    #region Notation declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/number/Notation.html"/>
    /// </summary>
    public partial class Notation : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Notation>
    {
        const string _bridgeClassName = "android.icu.number.Notation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Notation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Notation(params object[] args) : base(args) { }
    
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

    #region Notation implementation
    public partial class Notation
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Notation.html#compactLong()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.CompactNotation"/></returns>
        public static Android.Icu.Number.CompactNotation CompactLong()
        {
            return SExecuteWithSignature<Android.Icu.Number.CompactNotation>(LocalBridgeClazz, "compactLong", "()Landroid/icu/number/CompactNotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Notation.html#compactShort()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.CompactNotation"/></returns>
        public static Android.Icu.Number.CompactNotation CompactShort()
        {
            return SExecuteWithSignature<Android.Icu.Number.CompactNotation>(LocalBridgeClazz, "compactShort", "()Landroid/icu/number/CompactNotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Notation.html#engineering()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.ScientificNotation"/></returns>
        public static Android.Icu.Number.ScientificNotation Engineering()
        {
            return SExecuteWithSignature<Android.Icu.Number.ScientificNotation>(LocalBridgeClazz, "engineering", "()Landroid/icu/number/ScientificNotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Notation.html#scientific()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.ScientificNotation"/></returns>
        public static Android.Icu.Number.ScientificNotation Scientific()
        {
            return SExecuteWithSignature<Android.Icu.Number.ScientificNotation>(LocalBridgeClazz, "scientific", "()Landroid/icu/number/ScientificNotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Notation.html#simple()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.SimpleNotation"/></returns>
        public static Android.Icu.Number.SimpleNotation Simple()
        {
            return SExecuteWithSignature<Android.Icu.Number.SimpleNotation>(LocalBridgeClazz, "simple", "()Landroid/icu/number/SimpleNotation;");
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}