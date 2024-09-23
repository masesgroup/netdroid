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

namespace Android.Util
{
    #region JsonReader declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/JsonReader.html"/>
    /// </summary>
    public partial class JsonReader : Java.Io.Closeable
    {
        const string _bridgeClassName = "android.util.JsonReader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JsonReader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JsonReader(params object[] args) : base(args) { }
    
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

    #region JsonReader implementation
    public partial class JsonReader
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#%3Cinit%3E(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        public JsonReader(Java.Io.Reader arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#peek()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.JsonToken"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonToken Peek()
        {
            return IExecuteWithSignature<Android.Util.JsonToken>("peek", "()Landroid/util/JsonToken;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool HasNext()
        {
            return IExecuteWithSignature<bool>("hasNext", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#isLenient()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLenient()
        {
            return IExecuteWithSignature<bool>("isLenient", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#nextBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool NextBoolean()
        {
            return IExecuteWithSignature<bool>("nextBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#nextDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double NextDouble()
        {
            return IExecuteWithSignature<double>("nextDouble", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#nextInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int NextInt()
        {
            return IExecuteWithSignature<int>("nextInt", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#nextName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String NextName()
        {
            return IExecuteWithSignature<Java.Lang.String>("nextName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#nextString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String NextString()
        {
            return IExecuteWithSignature<Java.Lang.String>("nextString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#nextLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long NextLong()
        {
            return IExecuteWithSignature<long>("nextLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#beginArray()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void BeginArray()
        {
            IExecuteWithSignature("beginArray", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#beginObject()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void BeginObject()
        {
            IExecuteWithSignature("beginObject", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#endArray()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void EndArray()
        {
            IExecuteWithSignature("endArray", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#endObject()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void EndObject()
        {
            IExecuteWithSignature("endObject", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#nextNull()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void NextNull()
        {
            IExecuteWithSignature("nextNull", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#setLenient(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLenient(bool arg0)
        {
            IExecuteWithSignature("setLenient", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonReader.html#skipValue()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void SkipValue()
        {
            IExecuteWithSignature("skipValue", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}