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

namespace Android.View.Inspector
{
    #region InspectionCompanion declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inspector/InspectionCompanion.html"/>
    /// </summary>
    public partial class InspectionCompanion : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InspectionCompanion>
    {
        const string _bridgeClassName = "android.view.inspector.InspectionCompanion";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InspectionCompanion class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InspectionCompanion() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InspectionCompanion class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InspectionCompanion(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region UninitializedPropertyMapException declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/InspectionCompanion.UninitializedPropertyMapException.html"/>
        /// </summary>
        public partial class UninitializedPropertyMapException : Java.Lang.RuntimeException
        {
            const string _bridgeClassName = "android.view.inspector.InspectionCompanion$UninitializedPropertyMapException";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region InspectionCompanion<T> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inspector/InspectionCompanion.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class InspectionCompanion<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InspectionCompanion<T>>
    {
        const string _bridgeClassName = "android.view.inspector.InspectionCompanion";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InspectionCompanion class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InspectionCompanion() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InspectionCompanion class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InspectionCompanion(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region InspectionCompanion implementation
    public partial class InspectionCompanion
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/InspectionCompanion.html#mapProperties(android.view.inspector.PropertyMapper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inspector.PropertyMapper"/></param>
        public void MapProperties(Android.View.Inspector.PropertyMapper arg0)
        {
            IExecuteWithSignature("mapProperties", "(Landroid/view/inspector/PropertyMapper;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/InspectionCompanion.html#readProperties(java.lang.Object,android.view.inspector.PropertyReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Android.View.Inspector.PropertyReader"/></param>
        public void ReadProperties(object arg0, Android.View.Inspector.PropertyReader arg1)
        {
            IExecute("readProperties", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region UninitializedPropertyMapException implementation
        public partial class UninitializedPropertyMapException
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IInspectionCompanion<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInspectionCompanion<T>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region InspectionCompanion<T> implementation
    public partial class InspectionCompanion<T> : Android.View.Inspector.IInspectionCompanion<T>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.View.Inspector.InspectionCompanion{T}"/> to <see cref="Android.View.Inspector.InspectionCompanion"/>
        /// </summary>
        public static implicit operator Android.View.Inspector.InspectionCompanion(Android.View.Inspector.InspectionCompanion<T> t) => t.Cast<Android.View.Inspector.InspectionCompanion>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/InspectionCompanion.html#mapProperties(android.view.inspector.PropertyMapper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inspector.PropertyMapper"/></param>
        public void MapProperties(Android.View.Inspector.PropertyMapper arg0)
        {
            IExecuteWithSignature("mapProperties", "(Landroid/view/inspector/PropertyMapper;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/InspectionCompanion.html#readProperties(java.lang.Object,android.view.inspector.PropertyReader)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.View.Inspector.PropertyReader"/></param>
        public void ReadProperties(T arg0, Android.View.Inspector.PropertyReader arg1)
        {
            IExecute("readProperties", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}