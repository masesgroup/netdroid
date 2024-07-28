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

namespace Org.Apache.Http.Params
{
    #region IHttpParams
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHttpParams
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HttpParams
    public partial class HttpParams : Org.Apache.Http.Params.IHttpParams
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
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#getBooleanParameter(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetBooleanParameter(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<bool>("getBooleanParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#isParameterFalse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsParameterFalse(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isParameterFalse", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#isParameterTrue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsParameterTrue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isParameterTrue", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#removeParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool RemoveParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("removeParameter", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#getDoubleParameter(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        [global::System.Obsolete()]
        public double GetDoubleParameter(Java.Lang.String arg0, double arg1)
        {
            return IExecute<double>("getDoubleParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#getIntParameter(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetIntParameter(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("getIntParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        [global::System.Obsolete()]
        public object GetParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#getLongParameter(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetLongParameter(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("getLongParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#copy()"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Http.Params.HttpParams"/></returns>
        [global::System.Obsolete()]
        public Org.Apache.Http.Params.HttpParams Copy()
        {
            return IExecuteWithSignature<Org.Apache.Http.Params.HttpParams>("copy", "()Lorg/apache/http/params/HttpParams;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#setBooleanParameter(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Org.Apache.Http.Params.HttpParams"/></returns>
        [global::System.Obsolete()]
        public Org.Apache.Http.Params.HttpParams SetBooleanParameter(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<Org.Apache.Http.Params.HttpParams>("setBooleanParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#setDoubleParameter(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Org.Apache.Http.Params.HttpParams"/></returns>
        [global::System.Obsolete()]
        public Org.Apache.Http.Params.HttpParams SetDoubleParameter(Java.Lang.String arg0, double arg1)
        {
            return IExecute<Org.Apache.Http.Params.HttpParams>("setDoubleParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#setIntParameter(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Http.Params.HttpParams"/></returns>
        [global::System.Obsolete()]
        public Org.Apache.Http.Params.HttpParams SetIntParameter(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Org.Apache.Http.Params.HttpParams>("setIntParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#setLongParameter(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Http.Params.HttpParams"/></returns>
        [global::System.Obsolete()]
        public Org.Apache.Http.Params.HttpParams SetLongParameter(Java.Lang.String arg0, long arg1)
        {
            return IExecute<Org.Apache.Http.Params.HttpParams>("setLongParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpParams.html#setParameter(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Http.Params.HttpParams"/></returns>
        [global::System.Obsolete()]
        public Org.Apache.Http.Params.HttpParams SetParameter(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Org.Apache.Http.Params.HttpParams>("setParameter", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}