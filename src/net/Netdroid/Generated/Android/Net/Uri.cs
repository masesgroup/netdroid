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

namespace Android.Net
{
    #region Uri declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/Uri.html"/>
    /// </summary>
    public partial class Uri : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Uri>
    {
        const string _bridgeClassName = "android.net.Uri";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Uri class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Uri() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Uri class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Uri(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.Uri$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

    #region Uri implementation
    public partial class Uri : Android.Os.IParcelable, Java.Lang.IComparable<Android.Net.Uri>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Net.Uri"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Net.Uri t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Net.Uri"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Android.Net.Uri t) => t.Cast<Java.Lang.Comparable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#EMPTY"/>
        /// </summary>
        public static Android.Net.Uri EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Android.Net.Uri>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Android.Net.Uri _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#fromFile(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public static Android.Net.Uri FromFile(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Android.Net.Uri>(LocalBridgeClazz, "fromFile", "(Ljava/io/File;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#fromParts(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public static Android.Net.Uri FromParts(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecuteWithSignature<Android.Net.Uri>(LocalBridgeClazz, "fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public static Android.Net.Uri Parse(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Net.Uri>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#withAppendedPath(android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public static Android.Net.Uri WithAppendedPath(Android.Net.Uri arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Android.Net.Uri>(LocalBridgeClazz, "withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Decode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "decode", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#encode(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Encode(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#encode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Encode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "encode", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#writeToParcel(android.os.Parcel,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        public static void WriteToParcel(Android.Os.Parcel arg0, Android.Net.Uri arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#buildUpon()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
        public Android.Net.Uri.Builder BuildUpon()
        {
            return IExecuteWithSignature<Android.Net.Uri.Builder>("buildUpon", "()Landroid/net/Uri$Builder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#isHierarchical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHierarchical()
        {
            return IExecuteWithSignature<bool>("isHierarchical", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#isRelative()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRelative()
        {
            return IExecuteWithSignature<bool>("isRelative", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPort()
        {
            return IExecuteWithSignature<int>("getPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getAuthority()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAuthority()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAuthority", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getEncodedAuthority()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncodedAuthority()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncodedAuthority", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getEncodedFragment()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncodedFragment()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncodedFragment", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getEncodedPath()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncodedPath()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncodedPath", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getEncodedQuery()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncodedQuery()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncodedQuery", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getEncodedSchemeSpecificPart()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncodedSchemeSpecificPart()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncodedSchemeSpecificPart", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getEncodedUserInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncodedUserInfo()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncodedUserInfo", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getFragment()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFragment()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFragment", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getHost()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHost()
        {
            return IExecuteWithSignature<Java.Lang.String>("getHost", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getLastPathSegment()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLastPathSegment()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLastPathSegment", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getPath()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPath()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPath", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getQuery()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetQuery()
        {
            return IExecuteWithSignature<Java.Lang.String>("getQuery", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getScheme()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetScheme()
        {
            return IExecuteWithSignature<Java.Lang.String>("getScheme", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getSchemeSpecificPart()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSchemeSpecificPart()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSchemeSpecificPart", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getUserInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUserInfo()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUserInfo", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getPathSegments()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetPathSegments()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getPathSegments", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#normalizeScheme()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri NormalizeScheme()
        {
            return IExecuteWithSignature<Android.Net.Uri>("normalizeScheme", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getBooleanQueryParameter(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBooleanQueryParameter(Java.Lang.String arg0, bool arg1)
        {
            return IExecuteWithSignature<bool>("getBooleanQueryParameter", "(Ljava/lang/String;Z)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#isAbsolute()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAbsolute()
        {
            return IExecuteWithSignature<bool>("isAbsolute", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#isOpaque()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpaque()
        {
            return IExecuteWithSignature<bool>("isOpaque", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#compareTo(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/net/Uri;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getQueryParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetQueryParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getQueryParameters(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetQueryParameters(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Uri.html#getQueryParameterNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetQueryParameterNames()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getQueryParameterNames", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Uri"/></returns>
            public Android.Net.Uri Build()
            {
                return IExecuteWithSignature<Android.Net.Uri>("build", "()Landroid/net/Uri;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#appendEncodedPath(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder AppendEncodedPath(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#appendPath(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder AppendPath(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#appendQueryParameter(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder AppendQueryParameter(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#authority(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder Authority(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#clearQuery()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder ClearQuery()
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("clearQuery", "()Landroid/net/Uri$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#encodedAuthority(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder EncodedAuthority(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#encodedFragment(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder EncodedFragment(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#encodedOpaquePart(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder EncodedOpaquePart(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#encodedPath(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder EncodedPath(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#encodedQuery(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder EncodedQuery(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#fragment(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder Fragment(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#opaquePart(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder OpaquePart(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#path(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder Path(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#query(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder Query(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/Uri.Builder.html#scheme(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
            public Android.Net.Uri.Builder Scheme(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Uri.Builder>("scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", arg0);
            }
        
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