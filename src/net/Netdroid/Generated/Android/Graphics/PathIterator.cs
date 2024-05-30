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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region PathIterator
    public partial class PathIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#VERB_CLOSE"/>
        /// </summary>
        public static int VERB_CLOSE { get { if (!_VERB_CLOSEReady) { _VERB_CLOSEContent = SGetField<int>(LocalBridgeClazz, "VERB_CLOSE"); _VERB_CLOSEReady = true; } return _VERB_CLOSEContent; } }
        private static int _VERB_CLOSEContent = default;
        private static bool _VERB_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#VERB_CONIC"/>
        /// </summary>
        public static int VERB_CONIC { get { if (!_VERB_CONICReady) { _VERB_CONICContent = SGetField<int>(LocalBridgeClazz, "VERB_CONIC"); _VERB_CONICReady = true; } return _VERB_CONICContent; } }
        private static int _VERB_CONICContent = default;
        private static bool _VERB_CONICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#VERB_CUBIC"/>
        /// </summary>
        public static int VERB_CUBIC { get { if (!_VERB_CUBICReady) { _VERB_CUBICContent = SGetField<int>(LocalBridgeClazz, "VERB_CUBIC"); _VERB_CUBICReady = true; } return _VERB_CUBICContent; } }
        private static int _VERB_CUBICContent = default;
        private static bool _VERB_CUBICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#VERB_DONE"/>
        /// </summary>
        public static int VERB_DONE { get { if (!_VERB_DONEReady) { _VERB_DONEContent = SGetField<int>(LocalBridgeClazz, "VERB_DONE"); _VERB_DONEReady = true; } return _VERB_DONEContent; } }
        private static int _VERB_DONEContent = default;
        private static bool _VERB_DONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#VERB_LINE"/>
        /// </summary>
        public static int VERB_LINE { get { if (!_VERB_LINEReady) { _VERB_LINEContent = SGetField<int>(LocalBridgeClazz, "VERB_LINE"); _VERB_LINEReady = true; } return _VERB_LINEContent; } }
        private static int _VERB_LINEContent = default;
        private static bool _VERB_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#VERB_MOVE"/>
        /// </summary>
        public static int VERB_MOVE { get { if (!_VERB_MOVEReady) { _VERB_MOVEContent = SGetField<int>(LocalBridgeClazz, "VERB_MOVE"); _VERB_MOVEReady = true; } return _VERB_MOVEContent; } }
        private static int _VERB_MOVEContent = default;
        private static bool _VERB_MOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#VERB_QUAD"/>
        /// </summary>
        public static int VERB_QUAD { get { if (!_VERB_QUADReady) { _VERB_QUADContent = SGetField<int>(LocalBridgeClazz, "VERB_QUAD"); _VERB_QUADReady = true; } return _VERB_QUADContent; } }
        private static int _VERB_QUADContent = default;
        private static bool _VERB_QUADReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecuteWithSignature<bool>("hasNext", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#next(float[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Next(float[] arg0, int arg1)
        {
            return IExecute<int>("next", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#peek()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Peek()
        {
            return IExecuteWithSignature<int>("peek", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Next()
        {
            return IExecuteWithSignature("next", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes
        #region Segment
        public partial class Segment
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
            /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.Segment.html#getConicWeight()"/> 
            /// </summary>
            public float ConicWeight
            {
                get { return IExecuteWithSignature<float>("getConicWeight", "()F"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.Segment.html#getPoints()"/> 
            /// </summary>
            public float[] Points
            {
                get { return IExecuteWithSignatureArray<float>("getPoints", "()[F"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/PathIterator.Segment.html#getVerb()"/> 
            /// </summary>
            public int Verb
            {
                get { return IExecuteWithSignature<int>("getVerb", "()I"); }
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