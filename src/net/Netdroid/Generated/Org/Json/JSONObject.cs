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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Json
{
    #region JSONObject
    public partial class JSONObject
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Json.JSONException"/>
        public JSONObject(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public JSONObject(Java.Util.Map arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#%3Cinit%3E(org.json.JSONObject,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Json.JSONObject"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Json.JSONException"/>
        public JSONObject(Org.Json.JSONObject arg0, Java.Lang.String[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#%3Cinit%3E(org.json.JSONTokener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Json.JSONTokener"/></param>
        /// <exception cref="Org.Json.JSONException"/>
        public JSONObject(Org.Json.JSONTokener arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#NULL"/>
        /// </summary>
        public static object NULL { get { if (!_NULLReady) { _NULLContent = SGetField(LocalBridgeClazz, "NULL"); _NULLReady = true; } return _NULLContent; } }
        private static object _NULLContent = default;
        private static bool _NULLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#wrap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public static object Wrap(object arg0)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "wrap", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#numberToString(java.lang.Number)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Number"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public static Java.Lang.String NumberToString(Java.Lang.Number arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "numberToString", "(Ljava/lang/Number;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#quote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Quote(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "quote", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#getBoolean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public bool GetBoolean(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getBoolean", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#has(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Has(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("has", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#isNull(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNull(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isNull", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OptBoolean(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<bool>("optBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optBoolean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OptBoolean(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("optBoolean", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#getDouble(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public double GetDouble(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<double>("getDouble", "(Ljava/lang/String;)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optDouble(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double OptDouble(Java.Lang.String arg0, double arg1)
        {
            return IExecute<double>("optDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optDouble(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="double"/></returns>
        public double OptDouble(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<double>("optDouble", "(Ljava/lang/String;)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#getInt(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public int GetInt(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getInt", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int OptInt(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("optInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optInt(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int OptInt(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("optInt", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public object Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#opt(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object Opt(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("opt", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#remove(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("remove", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#getString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Java.Lang.String GetString(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optString(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OptString(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("optString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OptString(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("optString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Java.Lang.String ToString(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#keys()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Java.Lang.String> Keys()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Java.Lang.String>>("keys", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#getLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public long GetLong(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long OptLong(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("optLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        public long OptLong(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<long>("optLong", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#getJSONArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Json.JSONArray"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONArray GetJSONArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Json.JSONArray>("getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#names()"/>
        /// </summary>
        /// <returns><see cref="Org.Json.JSONArray"/></returns>
        public Org.Json.JSONArray Names()
        {
            return IExecuteWithSignature<Org.Json.JSONArray>("names", "()Lorg/json/JSONArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optJSONArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Json.JSONArray"/></returns>
        public Org.Json.JSONArray OptJSONArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Json.JSONArray>("optJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#toJSONArray(org.json.JSONArray)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Json.JSONArray"/></param>
        /// <returns><see cref="Org.Json.JSONArray"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONArray ToJSONArray(Org.Json.JSONArray arg0)
        {
            return IExecuteWithSignature<Org.Json.JSONArray>("toJSONArray", "(Lorg/json/JSONArray;)Lorg/json/JSONArray;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#accumulate(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject Accumulate(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Org.Json.JSONObject>("accumulate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#append(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject Append(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Org.Json.JSONObject>("append", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#getJSONObject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject GetJSONObject(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Json.JSONObject>("getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#optJSONObject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        public Org.Json.JSONObject OptJSONObject(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Json.JSONObject>("optJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#put(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject Put(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<Org.Json.JSONObject>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#put(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject Put(Java.Lang.String arg0, double arg1)
        {
            return IExecute<Org.Json.JSONObject>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#put(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject Put(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Org.Json.JSONObject>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject Put(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Org.Json.JSONObject>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#put(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject Put(Java.Lang.String arg0, long arg1)
        {
            return IExecute<Org.Json.JSONObject>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONObject.html#putOpt(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Json.JSONObject"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Org.Json.JSONObject PutOpt(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Org.Json.JSONObject>("putOpt", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}