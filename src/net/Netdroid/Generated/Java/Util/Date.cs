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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Date
    public partial class Date : Java.Io.ISerializable, Java.Lang.ICloneable, Java.Lang.IComparable<Java.Util.Date>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#%3Cinit%3E(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#%3Cinit%3E(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Date(int arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Date(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public Date(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public Date(long arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Date"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Date t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Date"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Date t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Date"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Util.Date t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#from(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public static Java.Util.Date From(Java.Time.Instant arg0)
        {
            return SExecuteWithSignature<Java.Util.Date>(LocalBridgeClazz, "from", "(Ljava/time/Instant;)Ljava/util/Date;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long Parse(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#UTC(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return SExecute<long>(LocalBridgeClazz, "UTC", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#after(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool After(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<bool>("after", "(Ljava/util/Date;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#before(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Before(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<bool>("before", "(Ljava/util/Date;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#compareTo(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/util/Date;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getDate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetDate()
        {
            return IExecuteWithSignature<int>("getDate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getDay()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetDay()
        {
            return IExecuteWithSignature<int>("getDay", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getHours()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetHours()
        {
            return IExecuteWithSignature<int>("getHours", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getMinutes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMinutes()
        {
            return IExecuteWithSignature<int>("getMinutes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMonth()
        {
            return IExecuteWithSignature<int>("getMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getSeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetSeconds()
        {
            return IExecuteWithSignature<int>("getSeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getTimezoneOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetTimezoneOffset()
        {
            return IExecuteWithSignature<int>("getTimezoneOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetYear()
        {
            return IExecuteWithSignature<int>("getYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#toGMTString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String ToGMTString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toGMTString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#toLocaleString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String ToLocaleString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toLocaleString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#toInstant()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant ToInstant()
        {
            return IExecuteWithSignature<Java.Time.Instant>("toInstant", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#getTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTime()
        {
            return IExecuteWithSignature<long>("getTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#setDate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetDate(int arg0)
        {
            IExecuteWithSignature("setDate", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#setHours(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetHours(int arg0)
        {
            IExecuteWithSignature("setHours", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#setMinutes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetMinutes(int arg0)
        {
            IExecuteWithSignature("setMinutes", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#setMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetMonth(int arg0)
        {
            IExecuteWithSignature("setMonth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#setSeconds(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSeconds(int arg0)
        {
            IExecuteWithSignature("setSeconds", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#setTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetTime(long arg0)
        {
            IExecuteWithSignature("setTime", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Date.html#setYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetYear(int arg0)
        {
            IExecuteWithSignature("setYear", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}