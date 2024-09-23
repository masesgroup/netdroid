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

namespace Android.Drm
{
    #region DrmStore declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/drm/DrmStore.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class DrmStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DrmStore>
    {
        const string _bridgeClassName = "android.drm.DrmStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DrmStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DrmStore(params object[] args) : base(args) { }
    
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
        #region Action declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Action : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Action>
        {
            const string _bridgeClassName = "android.drm.DrmStore$Action";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Action() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Action(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region ConstraintsColumns declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmStore.ConstraintsColumns.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class ConstraintsColumns : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConstraintsColumns>
        {
            const string _bridgeClassName = "android.drm.DrmStore$ConstraintsColumns";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("ConstraintsColumns class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ConstraintsColumns() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("ConstraintsColumns class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ConstraintsColumns(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region DrmObjectType declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmStore.DrmObjectType.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class DrmObjectType : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DrmObjectType>
        {
            const string _bridgeClassName = "android.drm.DrmStore$DrmObjectType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DrmObjectType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DrmObjectType(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region Playback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Playback.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Playback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Playback>
        {
            const string _bridgeClassName = "android.drm.DrmStore$Playback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Playback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Playback(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region RightsStatus declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmStore.RightsStatus.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class RightsStatus : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RightsStatus>
        {
            const string _bridgeClassName = "android.drm.DrmStore$RightsStatus";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public RightsStatus() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public RightsStatus(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region DrmStore implementation
    public partial class DrmStore
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
        #region Action implementation
        public partial class Action
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#DEFAULT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
            private static int _DEFAULTContent = default;
            private static bool _DEFAULTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#DISPLAY"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int DISPLAY { get { if (!_DISPLAYReady) { _DISPLAYContent = SGetField<int>(LocalBridgeClazz, "DISPLAY"); _DISPLAYReady = true; } return _DISPLAYContent; } }
            private static int _DISPLAYContent = default;
            private static bool _DISPLAYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#EXECUTE"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int EXECUTE { get { if (!_EXECUTEReady) { _EXECUTEContent = SGetField<int>(LocalBridgeClazz, "EXECUTE"); _EXECUTEReady = true; } return _EXECUTEContent; } }
            private static int _EXECUTEContent = default;
            private static bool _EXECUTEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#OUTPUT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int OUTPUT { get { if (!_OUTPUTReady) { _OUTPUTContent = SGetField<int>(LocalBridgeClazz, "OUTPUT"); _OUTPUTReady = true; } return _OUTPUTContent; } }
            private static int _OUTPUTContent = default;
            private static bool _OUTPUTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#PLAY"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int PLAY { get { if (!_PLAYReady) { _PLAYContent = SGetField<int>(LocalBridgeClazz, "PLAY"); _PLAYReady = true; } return _PLAYContent; } }
            private static int _PLAYContent = default;
            private static bool _PLAYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#PREVIEW"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int PREVIEW { get { if (!_PREVIEWReady) { _PREVIEWContent = SGetField<int>(LocalBridgeClazz, "PREVIEW"); _PREVIEWReady = true; } return _PREVIEWContent; } }
            private static int _PREVIEWContent = default;
            private static bool _PREVIEWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#RINGTONE"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int RINGTONE { get { if (!_RINGTONEReady) { _RINGTONEContent = SGetField<int>(LocalBridgeClazz, "RINGTONE"); _RINGTONEReady = true; } return _RINGTONEContent; } }
            private static int _RINGTONEContent = default;
            private static bool _RINGTONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Action.html#TRANSFER"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int TRANSFER { get { if (!_TRANSFERReady) { _TRANSFERContent = SGetField<int>(LocalBridgeClazz, "TRANSFER"); _TRANSFERReady = true; } return _TRANSFERContent; } }
            private static int _TRANSFERContent = default;
            private static bool _TRANSFERReady = false; // this is used because in case of generics 
        
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

        #region ConstraintsColumns implementation
        public partial class ConstraintsColumns
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.ConstraintsColumns.html#EXTENDED_METADATA"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Java.Lang.String EXTENDED_METADATA { get { if (!_EXTENDED_METADATAReady) { _EXTENDED_METADATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTENDED_METADATA"); _EXTENDED_METADATAReady = true; } return _EXTENDED_METADATAContent; } }
            private static Java.Lang.String _EXTENDED_METADATAContent = default;
            private static bool _EXTENDED_METADATAReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.ConstraintsColumns.html#LICENSE_AVAILABLE_TIME"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Java.Lang.String LICENSE_AVAILABLE_TIME { get { if (!_LICENSE_AVAILABLE_TIMEReady) { _LICENSE_AVAILABLE_TIMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LICENSE_AVAILABLE_TIME"); _LICENSE_AVAILABLE_TIMEReady = true; } return _LICENSE_AVAILABLE_TIMEContent; } }
            private static Java.Lang.String _LICENSE_AVAILABLE_TIMEContent = default;
            private static bool _LICENSE_AVAILABLE_TIMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.ConstraintsColumns.html#LICENSE_EXPIRY_TIME"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Java.Lang.String LICENSE_EXPIRY_TIME { get { if (!_LICENSE_EXPIRY_TIMEReady) { _LICENSE_EXPIRY_TIMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LICENSE_EXPIRY_TIME"); _LICENSE_EXPIRY_TIMEReady = true; } return _LICENSE_EXPIRY_TIMEContent; } }
            private static Java.Lang.String _LICENSE_EXPIRY_TIMEContent = default;
            private static bool _LICENSE_EXPIRY_TIMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.ConstraintsColumns.html#LICENSE_START_TIME"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Java.Lang.String LICENSE_START_TIME { get { if (!_LICENSE_START_TIMEReady) { _LICENSE_START_TIMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LICENSE_START_TIME"); _LICENSE_START_TIMEReady = true; } return _LICENSE_START_TIMEContent; } }
            private static Java.Lang.String _LICENSE_START_TIMEContent = default;
            private static bool _LICENSE_START_TIMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.ConstraintsColumns.html#MAX_REPEAT_COUNT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Java.Lang.String MAX_REPEAT_COUNT { get { if (!_MAX_REPEAT_COUNTReady) { _MAX_REPEAT_COUNTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MAX_REPEAT_COUNT"); _MAX_REPEAT_COUNTReady = true; } return _MAX_REPEAT_COUNTContent; } }
            private static Java.Lang.String _MAX_REPEAT_COUNTContent = default;
            private static bool _MAX_REPEAT_COUNTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.ConstraintsColumns.html#REMAINING_REPEAT_COUNT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Java.Lang.String REMAINING_REPEAT_COUNT { get { if (!_REMAINING_REPEAT_COUNTReady) { _REMAINING_REPEAT_COUNTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REMAINING_REPEAT_COUNT"); _REMAINING_REPEAT_COUNTReady = true; } return _REMAINING_REPEAT_COUNTContent; } }
            private static Java.Lang.String _REMAINING_REPEAT_COUNTContent = default;
            private static bool _REMAINING_REPEAT_COUNTReady = false; // this is used because in case of generics 
        
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

        #region DrmObjectType implementation
        public partial class DrmObjectType
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.DrmObjectType.html#CONTENT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int CONTENT { get { if (!_CONTENTReady) { _CONTENTContent = SGetField<int>(LocalBridgeClazz, "CONTENT"); _CONTENTReady = true; } return _CONTENTContent; } }
            private static int _CONTENTContent = default;
            private static bool _CONTENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.DrmObjectType.html#RIGHTS_OBJECT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int RIGHTS_OBJECT { get { if (!_RIGHTS_OBJECTReady) { _RIGHTS_OBJECTContent = SGetField<int>(LocalBridgeClazz, "RIGHTS_OBJECT"); _RIGHTS_OBJECTReady = true; } return _RIGHTS_OBJECTContent; } }
            private static int _RIGHTS_OBJECTContent = default;
            private static bool _RIGHTS_OBJECTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.DrmObjectType.html#TRIGGER_OBJECT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int TRIGGER_OBJECT { get { if (!_TRIGGER_OBJECTReady) { _TRIGGER_OBJECTContent = SGetField<int>(LocalBridgeClazz, "TRIGGER_OBJECT"); _TRIGGER_OBJECTReady = true; } return _TRIGGER_OBJECTContent; } }
            private static int _TRIGGER_OBJECTContent = default;
            private static bool _TRIGGER_OBJECTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.DrmObjectType.html#UNKNOWN"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static int _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 
        
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

        #region Playback implementation
        public partial class Playback
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Playback.html#PAUSE"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int PAUSE { get { if (!_PAUSEReady) { _PAUSEContent = SGetField<int>(LocalBridgeClazz, "PAUSE"); _PAUSEReady = true; } return _PAUSEContent; } }
            private static int _PAUSEContent = default;
            private static bool _PAUSEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Playback.html#RESUME"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int RESUME { get { if (!_RESUMEReady) { _RESUMEContent = SGetField<int>(LocalBridgeClazz, "RESUME"); _RESUMEReady = true; } return _RESUMEContent; } }
            private static int _RESUMEContent = default;
            private static bool _RESUMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Playback.html#START"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int START { get { if (!_STARTReady) { _STARTContent = SGetField<int>(LocalBridgeClazz, "START"); _STARTReady = true; } return _STARTContent; } }
            private static int _STARTContent = default;
            private static bool _STARTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.Playback.html#STOP"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int STOP { get { if (!_STOPReady) { _STOPContent = SGetField<int>(LocalBridgeClazz, "STOP"); _STOPReady = true; } return _STOPContent; } }
            private static int _STOPContent = default;
            private static bool _STOPReady = false; // this is used because in case of generics 
        
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

        #region RightsStatus implementation
        public partial class RightsStatus
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.RightsStatus.html#RIGHTS_EXPIRED"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int RIGHTS_EXPIRED { get { if (!_RIGHTS_EXPIREDReady) { _RIGHTS_EXPIREDContent = SGetField<int>(LocalBridgeClazz, "RIGHTS_EXPIRED"); _RIGHTS_EXPIREDReady = true; } return _RIGHTS_EXPIREDContent; } }
            private static int _RIGHTS_EXPIREDContent = default;
            private static bool _RIGHTS_EXPIREDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.RightsStatus.html#RIGHTS_INVALID"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int RIGHTS_INVALID { get { if (!_RIGHTS_INVALIDReady) { _RIGHTS_INVALIDContent = SGetField<int>(LocalBridgeClazz, "RIGHTS_INVALID"); _RIGHTS_INVALIDReady = true; } return _RIGHTS_INVALIDContent; } }
            private static int _RIGHTS_INVALIDContent = default;
            private static bool _RIGHTS_INVALIDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.RightsStatus.html#RIGHTS_NOT_ACQUIRED"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int RIGHTS_NOT_ACQUIRED { get { if (!_RIGHTS_NOT_ACQUIREDReady) { _RIGHTS_NOT_ACQUIREDContent = SGetField<int>(LocalBridgeClazz, "RIGHTS_NOT_ACQUIRED"); _RIGHTS_NOT_ACQUIREDReady = true; } return _RIGHTS_NOT_ACQUIREDContent; } }
            private static int _RIGHTS_NOT_ACQUIREDContent = default;
            private static bool _RIGHTS_NOT_ACQUIREDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmStore.RightsStatus.html#RIGHTS_VALID"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int RIGHTS_VALID { get { if (!_RIGHTS_VALIDReady) { _RIGHTS_VALIDContent = SGetField<int>(LocalBridgeClazz, "RIGHTS_VALID"); _RIGHTS_VALIDReady = true; } return _RIGHTS_VALIDContent; } }
            private static int _RIGHTS_VALIDContent = default;
            private static bool _RIGHTS_VALIDReady = false; // this is used because in case of generics 
        
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
}