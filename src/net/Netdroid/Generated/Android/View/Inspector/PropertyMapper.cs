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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Inspector
{
    #region IPropertyMapper
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPropertyMapper
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PropertyMapper
    public partial class PropertyMapper : Android.View.Inspector.IPropertyMapper
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
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapBoolean(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapBoolean(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapByte(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapByte(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapChar(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapChar(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapColor(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapColor(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapDouble(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapDouble(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapFloat(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapFloat(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapGravity(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapGravity(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapGravity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapInt(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapIntEnum(java.lang.String,int,java.util.function.IntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntFunction"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapIntEnum(Java.Lang.String arg0, int arg1, Java.Util.Function.IntFunction<Java.Lang.String> arg2)
        {
            return IExecute<int>("mapIntEnum", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapIntFlag(java.lang.String,int,java.util.function.IntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntFunction"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapIntFlag(Java.Lang.String arg0, int arg1, Java.Util.Function.IntFunction<Java.Util.Set<Java.Lang.String>> arg2)
        {
            return IExecute<int>("mapIntFlag", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapLong(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapLong(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapObject(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapObject(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapObject", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapResourceId(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapResourceId(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapResourceId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inspector/PropertyMapper.html#mapShort(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MapShort(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("mapShort", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region PropertyConflictException
        public partial class PropertyConflictException
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
}